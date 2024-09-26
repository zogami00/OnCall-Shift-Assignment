using System;
using System.Collections.Generic;
using System.Linq;
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
        public void AssignShifts(List<Person> people, DateTime startDate, DateTime endDate, Action<int> reportProgress)
        {
            // Get all dates in the range
            List<DateTime> allDates = GetAllDates(startDate, endDate);

            // Separate weekends and weekdays
            List<DateTime> weekends = allDates.Where(date => date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday).ToList();
            List<DateTime> weekdays = allDates.Except(weekends).ToList();

            // Total number of shifts is the sum of weekends and weekdays
            int totalShifts = weekends.Count + weekdays.Count;
            int progress = 0;

            // Assign weekday shifts first
            AssignWeekdayShifts(people, weekdays, reportProgress, ref progress, totalShifts);

            // Now assign weekend shifts
            AssignWeekendShifts(people, weekends, reportProgress, ref progress, totalShifts);
        }

        private void AssignWeekendShifts(List<Person> people, List<DateTime> weekends, Action<int> reportProgress, ref int progress, int totalShifts)
        {
            foreach (DateTime weekend in weekends)
            {
                bool shiftAssigned = false;
                string reason = ""; // Store the reason for why a shift cannot be assigned

                // Sort people by their weekday-weekend shift balance (prioritize those with fewer weekend shifts)
                var sortedPeople = people.OrderBy(p => p.WeekendShifts - p.WeekdayShifts).ThenBy(p => p.WeekendShifts + p.WeekdayShifts).ToList();

                foreach (var currentPerson in sortedPeople)
                {
                    // Check if this person can be assigned the shift
                    if (currentPerson.LeaveDates.Contains(weekend.Date))
                    {
                        reason = $"{currentPerson.Name} is on leave on {weekend.ToShortDateString()}.";
                    }
                    else if (currentPerson.LastAssignedShift.HasValue && (weekend - currentPerson.LastAssignedShift.Value).Days == 1)
                    {
                        reason = $"{currentPerson.Name} has a shift on {currentPerson.LastAssignedShift.Value.ToShortDateString()} (consecutive day).";
                    }
                    else
                    {
                        // If both checks pass, assign the weekend shift
                        currentPerson.AssignedShifts.Add(weekend.Date);
                        currentPerson.WeekendShifts++;
                        currentPerson.LastAssignedShift = weekend.Date;
                        shiftAssigned = true; // Shift assigned successfully
                        reason = ""; // Clear the reason since the shift is assigned
                        break; // Shift assigned, break the loop
                    }
                }

                if (!shiftAssigned)
                {
                    // Handle case when no one can take this shift, display reason
                    MessageBox.Show($"No one available for shift on {weekend.ToShortDateString()}.\nReason: {reason}\nThis date will be skipped.");
                    continue;
                }

                progress++;

                // Report progress after each shift is processed
                reportProgress((progress * 100) / totalShifts);
            }
        }

        private void AssignWeekdayShifts(List<Person> people, List<DateTime> weekdays, Action<int> reportProgress, ref int progress, int totalShifts)
        {
            foreach (DateTime weekday in weekdays)
            {
                bool shiftAssigned = false;
                string reason = ""; // Store the reason for why a shift cannot be assigned

                // Sort people by their weekend-weekday shift balance (prioritize those with fewer weekday shifts)
                var sortedPeople = people.OrderBy(p => p.WeekdayShifts - p.WeekendShifts).ThenBy(p => p.WeekendShifts + p.WeekdayShifts).ToList();

                foreach (var currentPerson in sortedPeople)
                {
                    // Check if this person can be assigned the shift
                    if (currentPerson.LeaveDates.Contains(weekday.Date))
                    {
                        reason = $"{currentPerson.Name} is on leave on {weekday.ToShortDateString()}.";
                    }
                    else if (currentPerson.LastAssignedShift.HasValue && (weekday - currentPerson.LastAssignedShift.Value).Days == 1)
                    {
                        reason = $"{currentPerson.Name} has a shift on {currentPerson.LastAssignedShift.Value.ToShortDateString()} (consecutive day).";
                    }
                    else
                    {
                        // If both checks pass, assign the weekday shift
                        currentPerson.AssignedShifts.Add(weekday.Date);
                        currentPerson.WeekdayShifts++;
                        currentPerson.LastAssignedShift = weekday.Date;
                        shiftAssigned = true; // Shift assigned successfully
                        reason = ""; // Clear the reason since the shift is assigned
                        break; // Shift assigned, break the loop
                    }
                }

                if (!shiftAssigned)
                {
                    // Handle case when no one can take this shift, display reason
                    MessageBox.Show($"No one available for shift on {weekday.ToShortDateString()}.\nReason: {reason}\nThis date will be skipped.");
                    continue;
                }

                progress++;

                // Report progress after each shift is processed
                reportProgress((progress * 100) / totalShifts);
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
