using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TimeTable_Generator
{
    public class GenerateClass
    {
        public void GenerateTimetableExcel(List<Person> people, string filePath)
        {
            // Initialize the Excel package
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // For non-commercial use
            using (ExcelPackage package = new ExcelPackage())
            {
                // Create a worksheet
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Timetable");

                // Add headers
                worksheet.Cells[1, 1].Value = "Date";
                worksheet.Cells[1, 2].Value = "Name";

                // Step 1: Flatten the list of people and their shifts into a list of (Date, Name) pairs
                var shifts = people.SelectMany(person => person.AssignedShifts.Select(shiftDate => new { Date = shiftDate, Name = person.Name }))
                                   .OrderBy(shift => shift.Date)  // Step 2: Sort the list by Date
                                   .ToList();

                // Step 3: Populate the Excel file
                int row = 2;
                foreach (var shift in shifts)
                {
                    worksheet.Cells[row, 1].Value = shift.Date.ToShortDateString();  // Date of the shift
                    worksheet.Cells[row, 2].Value = shift.Name;                      // Name of the person
                    row++;
                }

                // Save the file
                FileInfo fileInfo = new FileInfo(filePath);
                package.SaveAs(fileInfo);
            }
        }
    }
}
