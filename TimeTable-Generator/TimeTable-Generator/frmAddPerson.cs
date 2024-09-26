﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TimeTable_Generator
{
    public partial class frmAddPerson : Form
    {
        DateTime StartDate;
        DateTime EndDate;

        public List<Person> people;
        private BackgroundWorker backgroundWorker;
        public frmAddPerson(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            titleBar1.SetParentForm(this);
            StartDate = startDate;
            EndDate = endDate;
            this.Load += FrmAddPerson_Load;
            people = new List<Person>();
            dataGridView1.AutoGenerateColumns = false;

        }
        public frmAddPerson(DateTime startDate, DateTime endDate, List<Person> people)
        {
            InitializeComponent();
            titleBar1.SetParentForm(this);
            StartDate = startDate;
            EndDate = endDate;
            this.Load += FrmAddPerson_Load;
            this.people = people;
            dataGridView1.AutoGenerateColumns = false;
        }

            private void FrmAddPerson_Load(object sender, EventArgs e)
        {
            // Initialize BackgroundWorker
            backgroundWorker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = false
            };

            // Assign event handlers for background worker
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;

            label_date.Text = $"Creating Timetable From {StartDate.ToString("d")} to {EndDate.ToString("d")}";
            dataGridView1.Columns["PersonName"].DataPropertyName = "Name";
            dataGridView1.Columns["AssignedShiftsString"].DataPropertyName = "AssignedShiftsString";
            dataGridView1.Columns["LeaveDatesString"].DataPropertyName = "LeaveDatesString";
            dataGridView1.Columns["WeekendShifts"].DataPropertyName = "WeekendShifts";
            dataGridView1.Columns["WeekdayShifts"].DataPropertyName = "WeekdayShifts";
            dataGridView1.Columns["TotalLeaveDays"].DataPropertyName = "TotalLeaveDays";

            RefreshDGV();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0; // Reset progress bar
            btn_assign.Enabled = false;
            // Start background worker
            backgroundWorker.RunWorkerAsync();
        }

        // Event handler for the BackgroundWorker's DoWork event
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ShiftsAlgorithm shiftsAlgorithm = new ShiftsAlgorithm();

            // Call the algorithm and pass a lambda function for progress reporting
            
            shiftsAlgorithm.AssignShifts(people, StartDate, EndDate, progress =>
            {
                backgroundWorker.ReportProgress(progress); // Report progress to UI
            });
        }

        // Event handler for reporting progress
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            RefreshDGV();
        }

        // Event handler for when the background worker completes
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Hide progress bar when work is done
            progressBar1.Visible = false;
            btn_assign.Enabled = true;

            // Refresh the DataGridView or perform other tasks
            RefreshDGV();
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            frmAddPersonDetails addPersonDetails = new frmAddPersonDetails(people);
            addPersonDetails.FormClosed += AddPersonDetails_FormClosed;
            addPersonDetails.ShowDialog();
        }

        private void RefreshDGV()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = people;
            int rowcount = dataGridView1.Rows.Count;

            label_total.Text = $"Total No of Person : {rowcount.ToString()}";
        }
        private void AddPersonDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshDGV();
            
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell cell = dataGridView1.SelectedCells[0];
                if (cell != null)
                {
                    int rowIndex = cell.RowIndex;

                    DataGridViewRow row = dataGridView1.Rows[rowIndex];

                    string name = row.Cells["PersonName"].Value.ToString();

                    Person personToRemove = people.FirstOrDefault(p => p.Name == name);

                    if (personToRemove != null)
                    {
                        // Remove the person from the list
                        people.Remove(personToRemove);
                        MessageBox.Show($"{name} has been removed from the list.");
                        
                    }
                    else
                    {
                        MessageBox.Show($"{name} not found in the list.");
                    }                                      
                }
            }
            else
            {
                MessageBox.Show($"Select a row in the list to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDGV();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell cell = dataGridView1.SelectedCells[0];
                if (cell != null)
                {
                    int rowIndex = cell.RowIndex;

                    DataGridViewRow row = dataGridView1.Rows[rowIndex];

                    string name = row.Cells["PersonName"].Value.ToString();

                    Person personToUpdate = people.FirstOrDefault(p => p.Name == name);

                    if (personToUpdate != null)
                    {
                        frmAddPersonDetails personDetails = new frmAddPersonDetails(people,personToUpdate);
                        personDetails.FormClosed += AddPersonDetails_FormClosed;
                        personDetails.ShowDialog();
                    }

                }
            }
        }


        private void btn_download_Click(object sender, EventArgs e)
        {
           GenerateClass generateClass = new GenerateClass();

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save the Timetable";
                saveFileDialog.FileName = "timetable_shifts.xlsx";  // Default filename

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the chosen file path
                    string filePath = saveFileDialog.FileName;

                    // Generate the Excel file
                    generateClass.GenerateTimetableExcel(people, filePath);

                    MessageBox.Show("Timetable has been exported to Excel!");
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            foreach (Person person in people)
            {
                person.AssignedShifts.Clear();
                person.WeekendShifts = 0;
                person.WeekdayShifts = 0;
                person.LastAssignedShift = null;
            }
            
            RefreshDGV();
        }

        private void rjButton2_Click_1(object sender, EventArgs e)
        {
            DataTransferClass dataTransfer = new DataTransferClass();

            dataTransfer.ExportDataToFile(people, StartDate, EndDate);
        }
    }
}