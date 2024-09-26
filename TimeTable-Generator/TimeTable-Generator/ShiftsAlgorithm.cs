using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static TimeTable_Generator.Person;
using ProgressBar = System.Windows.Forms.ProgressBar;

namespace TimeTable_Generator
{
    public class ShiftsAlgorithm
    {
        public void AssignShifts(List<Person> people, DateTime startDate, DateTime endDate, List<DateTime> publicHolidays, Action<int> reportProgress)
        {
            // Get all dates in the range
            List<DateTime> allDates = GetAllDates(startDate, endDate);

            // Separate weekends and weekdays
            List<DateTime> weekends = allDates.Where(date => date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday).ToList();
            List<DateTime> weekdays = allDates.Except(weekends).ToList();

            // Exclude public holidays from the list of weekdays
            var weekdaysExcludingHolidays = weekdays.Except(publicHolidays).ToList();

            // Combine weekends and public holidays into one list for weekend shifts
            var weekendAndHolidays = weekends.Union(publicHolidays).ToList();

            // Initialize a HashSet to track assigned shifts
            HashSet<DateTime> assignedShifts = new HashSet<DateTime>();

            // Calculate total shifts (weekdays + weekends, but not public holidays separately)
            int totalShifts = weekdaysExcludingHolidays.Count + weekendAndHolidays.Count;

            // Automatically calculate the ideal number of shifts per person
            int totalPeople = people.Count;
            int idealShiftsPerPerson = totalShifts / totalPeople;  // Integer division gives the base number of shifts each person should get
            int remainingShifts = totalShifts % totalPeople;       // Calculate any leftover shifts

            int progress = 0;

            // First pass: Assign regular shifts (both weekdays and weekend/public holidays)
            AssignRegularShifts(people, weekdaysExcludingHolidays, weekendAndHolidays, assignedShifts, reportProgress, ref progress, totalShifts, idealShiftsPerPerson);

            // Second pass: Assign remaining shifts to people with ExtraShift flag
            AssignExtraShifts(people, weekdaysExcludingHolidays, weekendAndHolidays, assignedShifts, reportProgress, ref progress, totalShifts);
        }


        private void AssignRegularShifts(List<Person> people, List<DateTime> weekdays, List<DateTime> weekendAndHolidays, HashSet<DateTime> assignedShifts, Action<int> reportProgress, ref int progress, int totalShifts, int idealShiftsPerPerson)
        {
            // Assign regular weekday shifts
            foreach (DateTime weekday in weekdays)
            {
                AssignShift(people, weekday, isWeekend: false, ref progress, totalShifts, reportProgress, idealShiftsPerPerson, assignedShifts);
            }

            // Assign regular weekend/public holiday shifts
            foreach (DateTime weekend in weekendAndHolidays)
            {
                AssignShift(people, weekend, isWeekend: true, ref progress, totalShifts, reportProgress, idealShiftsPerPerson, assignedShifts);
            }
        }


        private bool AssignShift(List<Person> people, DateTime date, bool isWeekend, ref int progress, int totalShifts, Action<int> reportProgress, int idealShiftsPerPerson, HashSet<DateTime> assignedShifts)
        {
            bool shiftAssigned = false;
            string reason = "";  // Track the reason for skipping

            // Sort people by balance of shifts (weekdays and weekends) and total number of assigned shifts
            var sortedPeople = people
                .Where(p => p.WeekdayShifts + p.WeekendShifts < idealShiftsPerPerson)  // Only assign to those who haven't reached the ideal number of shifts yet
                .OrderBy(p => Math.Abs(p.WeekendShifts - p.WeekdayShifts))  // Prioritize people with unbalanced shifts between weekday and weekend
                .ThenBy(p => p.WeekendShifts + p.WeekdayShifts)    // Prioritize people with fewer total shifts
                .ToList();

            foreach (var currentPerson in sortedPeople)
            {
                // Check leave dates and consecutive day constraints
                if (currentPerson.LeaveDates.Contains(date.Date))
                {
                    reason = $"{currentPerson.Name} is on leave for {date.ToShortDateString()}";
                }
                else if (currentPerson.LastAssignedShift.HasValue && (date - currentPerson.LastAssignedShift.Value).Days == 1)
                {
                    reason = $"{currentPerson.Name} has a consecutive shift issue for {date.ToShortDateString()}";
                }
                else
                {
                    // Assign the shift (weekend or weekday)
                    currentPerson.AssignedShifts.Add(date);
                    if (isWeekend)
                    {
                        currentPerson.WeekendShifts++;
                    }
                    else
                    {
                        currentPerson.WeekdayShifts++;
                    }
                    currentPerson.LastAssignedShift = date;
                    shiftAssigned = true;

                    // Add the assigned shift to the HashSet to track it
                    assignedShifts.Add(date);

                    break; // Shift assigned
                }
            }

            if (!shiftAssigned)
            {
                MessageBox.Show($"No shift assigned for {date.ToShortDateString()}. Reason: {reason}");
            }
            else
            {
                progress++;
                reportProgress((progress * 100) / totalShifts);
            }

            return shiftAssigned;  // Return whether the shift was assigned
        }
        private void AssignExtraShifts(List<Person> people, List<DateTime> weekdays, List<DateTime> weekendAndHolidays, HashSet<DateTime> assignedShifts, Action<int> reportProgress, ref int progress, int totalShifts)
        {
            // Calculate the remaining shifts (weekdays and weekends that were not assigned)
            var remainingShifts = weekdays.Concat(weekendAndHolidays)
                                          .Except(assignedShifts)
                                          .ToList();

            // Sort people with ExtraShift flag and assign remaining shifts
            foreach (DateTime date in remainingShifts.ToList())  // Iterate through a copy of the list
            {
                bool shiftAssigned = false;

                // Prioritize people with ExtraShift flag, maintaining balance of total shifts
                var extraShiftPeople = people
                    .Where(p => p.ExtraShift)  // Only consider people eligible for extra shifts
                    .OrderBy(p => p.WeekendShifts + p.WeekdayShifts)  // Prioritize people with fewer total shifts (weekday + weekend)
                    .ThenBy(p => Math.Abs(p.WeekendShifts - p.WeekdayShifts))  // Prioritize balancing weekday and weekend shifts
                    .ToList();

                foreach (var currentPerson in extraShiftPeople)
                {
                    if (!currentPerson.LeaveDates.Contains(date.Date) &&
                        (!currentPerson.LastAssignedShift.HasValue || (date - currentPerson.LastAssignedShift.Value).Days > 1))
                    {
                        // Assign the shift (weekend or weekday based on the day of the week)
                        currentPerson.AssignedShifts.Add(date);
                        if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday || weekendAndHolidays.Contains(date))
                        {
                            currentPerson.WeekendShifts++;
                        }
                        else
                        {
                            currentPerson.WeekdayShifts++;
                        }
                        currentPerson.LastAssignedShift = date;
                        shiftAssigned = true;

                        // Remove the date from remainingShifts so it's not assigned again
                        remainingShifts.Remove(date);
                        break; // Exit the loop once a shift is assigned
                    }
                }

                if (shiftAssigned)
                {
                    progress++;
                    reportProgress(Math.Min((progress * 100) / totalShifts, 100));
                }
            }
        }



        private List<DateTime> GetAllDates(DateTime startDate, DateTime endDate)
        {
            List<DateTime> allDates = new List<DateTime>();
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                allDates.Add(date);
            }
            return allDates;
        }
    }
}
