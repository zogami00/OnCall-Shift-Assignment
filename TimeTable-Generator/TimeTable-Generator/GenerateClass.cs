using DocumentFormat.OpenXml.Office2010.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = System.Drawing.Color;


namespace TimeTable_Generator
{
    public class GenerateClass
    {
        public void GenerateTimetableExcel(List<Person> people, string filePath, DateTime startDate, DateTime endDate, List<DateTime> publicHolidays)
        {
            // Initialize the Excel package
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // For non-commercial use
            using (ExcelPackage package = new ExcelPackage())
            {
                // Create a worksheet
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Timetable");

                // Add headers
                worksheet.Cells[1, 1].Value = "Date";
                worksheet.Cells[1, 2].Value = "Day";
                worksheet.Cells[1, 3].Value = "WeekDayShift";
                worksheet.Cells[1, 4].Value = "WeekEndShift";

                // Step 1: Flatten the list of people and their shifts into a list of (Date, Name) pairs
                var shifts = people.SelectMany(person => person.AssignedShifts.Select(shiftDate => new { Date = shiftDate, Name = person.Name }))
                                   .OrderBy(shift => shift.Date)  // Step 2: Sort the list by Date
                                   .ToList();

                List<DateTime> allDates = GetAllDates(startDate, endDate);

                // Separate weekends and weekdays
                List<DateTime> weekends = allDates.Where(date => date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday).ToList();
                List<DateTime> weekdays = allDates.Except(weekends).ToList();

                // Exclude public holidays from the list of weekdays
                var weekdaysExcludingHolidays = weekdays
                    .Where(day => !publicHolidays.Any(holiday => holiday.Date == day.Date))
                    .ToList();

                // Combine weekends and public holidays into one list for weekend shifts
                var weekendAndHolidays = weekends.Union(publicHolidays).ToList();
                
                // Step 3: Populate the Excel file
                int row = 2;
                foreach (var shift in shifts)
                {
                    
                    if (weekendAndHolidays.Contains(shift.Date))
                    {
                        if(publicHolidays.Contains(shift.Date))
                        {
                            worksheet.Cells[row, 3].Value = "(Public Holiday)";
                            worksheet.Cells[row, 3].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            worksheet.Cells[row, 3].Style.Fill.BackgroundColor.SetColor(Color.PaleGreen);
                        }
                        worksheet.Cells[row, 4].Value = shift.Name;                   
                    }
                    else
                    {
                        worksheet.Cells[row, 3].Value = shift.Name;                      

                    }



                    worksheet.Cells[row, 1].Value = shift.Date.ToShortDateString();  // Date of the shift
                    worksheet.Cells[row, 2].Value = shift.Date.DayOfWeek.ToString();  // Day of the shift
                                         // Name of the person

                    row++;
                }

                // Save the file
                FileInfo fileInfo = new FileInfo(filePath);
                package.SaveAs(fileInfo);
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
