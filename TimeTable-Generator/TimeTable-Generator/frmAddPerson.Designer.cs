﻿namespace TimeTable_Generator
{
    partial class frmAddPerson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear = new CustomControls.RJControls.RJButton();
            this.btn_date = new CustomControls.RJControls.RJButton();
            this.label_shift_total = new System.Windows.Forms.Label();
            this.label_shift_assign = new System.Windows.Forms.Label();
            this.label_holidays = new System.Windows.Forms.Label();
            this.btn_holidays = new CustomControls.RJControls.RJButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.btn_download = new CustomControls.RJControls.RJButton();
            this.btn_reset = new CustomControls.RJControls.RJButton();
            this.btn_assign = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.label_date = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.btn_continue = new CustomControls.RJControls.RJButton();
            this.panel_titlebar = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.titleBar1 = new Button_Control.TitleBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveDatesString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLeaveDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedShiftsString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveDates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedShifts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeekdayShifts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeekendShifts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel_titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_date);
            this.panel1.Controls.Add(this.label_shift_total);
            this.panel1.Controls.Add(this.label_shift_assign);
            this.panel1.Controls.Add(this.label_holidays);
            this.panel1.Controls.Add(this.btn_holidays);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.rjButton2);
            this.panel1.Controls.Add(this.btn_download);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.btn_assign);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.label_total);
            this.panel1.Controls.Add(this.btn_continue);
            this.panel1.Controls.Add(this.panel_titlebar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 606);
            this.panel1.TabIndex = 0;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_clear.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.btn_clear.BorderColor = System.Drawing.Color.Black;
            this.btn_clear.BorderRadius = 0;
            this.btn_clear.BorderSize = 1;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(173, 212);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(150, 26);
            this.btn_clear.TabIndex = 25;
            this.btn_clear.Text = "Clear All Dates";
            this.btn_clear.TextColor = System.Drawing.Color.Black;
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Visible = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_date
            // 
            this.btn_date.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_date.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.btn_date.BorderColor = System.Drawing.Color.Black;
            this.btn_date.BorderRadius = 0;
            this.btn_date.BorderSize = 1;
            this.btn_date.FlatAppearance.BorderSize = 0;
            this.btn_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_date.ForeColor = System.Drawing.Color.White;
            this.btn_date.Location = new System.Drawing.Point(173, 156);
            this.btn_date.Name = "btn_date";
            this.btn_date.Size = new System.Drawing.Size(150, 30);
            this.btn_date.TabIndex = 24;
            this.btn_date.Text = "Change Dates**";
            this.btn_date.TextColor = System.Drawing.Color.White;
            this.btn_date.UseVisualStyleBackColor = false;
            this.btn_date.Click += new System.EventHandler(this.btn_date_Click);
            // 
            // label_shift_total
            // 
            this.label_shift_total.AutoSize = true;
            this.label_shift_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_shift_total.Location = new System.Drawing.Point(475, 71);
            this.label_shift_total.Name = "label_shift_total";
            this.label_shift_total.Size = new System.Drawing.Size(99, 17);
            this.label_shift_total.TabIndex = 22;
            this.label_shift_total.Text = "Total Shifts : 0";
            // 
            // label_shift_assign
            // 
            this.label_shift_assign.AutoSize = true;
            this.label_shift_assign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_shift_assign.Location = new System.Drawing.Point(475, 88);
            this.label_shift_assign.Name = "label_shift_assign";
            this.label_shift_assign.Size = new System.Drawing.Size(157, 17);
            this.label_shift_assign.TabIndex = 23;
            this.label_shift_assign.Text = "Total Shifts Assigned: 0";
            // 
            // label_holidays
            // 
            this.label_holidays.AutoSize = true;
            this.label_holidays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_holidays.Location = new System.Drawing.Point(170, 86);
            this.label_holidays.Name = "label_holidays";
            this.label_holidays.Size = new System.Drawing.Size(156, 17);
            this.label_holidays.TabIndex = 21;
            this.label_holidays.Text = "Total No of Holidays : 0";
            // 
            // btn_holidays
            // 
            this.btn_holidays.BackColor = System.Drawing.Color.Lavender;
            this.btn_holidays.BackgroundColor = System.Drawing.Color.Lavender;
            this.btn_holidays.BorderColor = System.Drawing.Color.Black;
            this.btn_holidays.BorderRadius = 0;
            this.btn_holidays.BorderSize = 1;
            this.btn_holidays.FlatAppearance.BorderSize = 0;
            this.btn_holidays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_holidays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_holidays.ForeColor = System.Drawing.Color.Black;
            this.btn_holidays.Location = new System.Drawing.Point(173, 106);
            this.btn_holidays.Name = "btn_holidays";
            this.btn_holidays.Size = new System.Drawing.Size(150, 44);
            this.btn_holidays.TabIndex = 20;
            this.btn_holidays.Text = "Add Public Holidays";
            this.btn_holidays.TextColor = System.Drawing.Color.Black;
            this.btn_holidays.UseVisualStyleBackColor = false;
            this.btn_holidays.Click += new System.EventHandler(this.btn_holidays_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(677, 36);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(118, 23);
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Visible = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Thistle;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Thistle;
            this.rjButton2.BorderColor = System.Drawing.Color.Black;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 1;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.Black;
            this.rjButton2.Location = new System.Drawing.Point(637, 156);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(150, 30);
            this.rjButton2.TabIndex = 18;
            this.rjButton2.Text = "Export Data";
            this.rjButton2.TextColor = System.Drawing.Color.Black;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click_1);
            // 
            // btn_download
            // 
            this.btn_download.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_download.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.btn_download.BorderColor = System.Drawing.Color.Black;
            this.btn_download.BorderRadius = 0;
            this.btn_download.BorderSize = 1;
            this.btn_download.FlatAppearance.BorderSize = 0;
            this.btn_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_download.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_download.ForeColor = System.Drawing.Color.Black;
            this.btn_download.Location = new System.Drawing.Point(637, 106);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(150, 44);
            this.btn_download.TabIndex = 17;
            this.btn_download.Text = "Download TimeTable";
            this.btn_download.TextColor = System.Drawing.Color.Black;
            this.btn_download.UseVisualStyleBackColor = false;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.LightBlue;
            this.btn_reset.BackgroundColor = System.Drawing.Color.LightBlue;
            this.btn_reset.BorderColor = System.Drawing.Color.Black;
            this.btn_reset.BorderRadius = 0;
            this.btn_reset.BorderSize = 1;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.Black;
            this.btn_reset.Location = new System.Drawing.Point(481, 156);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(150, 30);
            this.btn_reset.TabIndex = 16;
            this.btn_reset.Text = "Reset Shifts";
            this.btn_reset.TextColor = System.Drawing.Color.Black;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_assign
            // 
            this.btn_assign.BackColor = System.Drawing.Color.Gold;
            this.btn_assign.BackgroundColor = System.Drawing.Color.Gold;
            this.btn_assign.BorderColor = System.Drawing.Color.Black;
            this.btn_assign.BorderRadius = 0;
            this.btn_assign.BorderSize = 1;
            this.btn_assign.FlatAppearance.BorderSize = 0;
            this.btn_assign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_assign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_assign.ForeColor = System.Drawing.Color.Black;
            this.btn_assign.Location = new System.Drawing.Point(481, 106);
            this.btn_assign.Name = "btn_assign";
            this.btn_assign.Size = new System.Drawing.Size(150, 44);
            this.btn_assign.TabIndex = 15;
            this.btn_assign.Text = "Assign Shifts";
            this.btn_assign.TextColor = System.Drawing.Color.Black;
            this.btn_assign.UseVisualStyleBackColor = false;
            this.btn_assign.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.LightPink;
            this.rjButton1.BackgroundColor = System.Drawing.Color.LightPink;
            this.rjButton1.BorderColor = System.Drawing.Color.Black;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(11, 156);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 30);
            this.rjButton1.TabIndex = 14;
            this.rjButton1.Text = "Delete Person";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // label_date
            // 
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(6, 36);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(548, 35);
            this.label_date.TabIndex = 13;
            this.label_date.Text = "Creating Timetable From DD/MM/yyyy to DD/MM/yyyy";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_total.Location = new System.Drawing.Point(11, 86);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(147, 17);
            this.label_total.TabIndex = 11;
            this.label_total.Text = "Total No of Person : 0";
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_continue.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.btn_continue.BorderColor = System.Drawing.Color.Black;
            this.btn_continue.BorderRadius = 0;
            this.btn_continue.BorderSize = 1;
            this.btn_continue.FlatAppearance.BorderSize = 0;
            this.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continue.ForeColor = System.Drawing.Color.Black;
            this.btn_continue.Location = new System.Drawing.Point(11, 106);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(150, 44);
            this.btn_continue.TabIndex = 6;
            this.btn_continue.Text = "Add New Person";
            this.btn_continue.TextColor = System.Drawing.Color.Black;
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // panel_titlebar
            // 
            this.panel_titlebar.BackColor = System.Drawing.Color.Orange;
            this.panel_titlebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_titlebar.Controls.Add(this.label4);
            this.panel_titlebar.Controls.Add(this.titleBar1);
            this.panel_titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titlebar.Location = new System.Drawing.Point(0, 0);
            this.panel_titlebar.Name = "panel_titlebar";
            this.panel_titlebar.Size = new System.Drawing.Size(798, 30);
            this.panel_titlebar.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Staff List";
            // 
            // titleBar1
            // 
            this.titleBar1.CloseMessage = "Exit Application?";
            this.titleBar1.CloseTitle = "Exit";
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.titleBar1.EnableDialog = false;
            this.titleBar1.Location = new System.Drawing.Point(692, 0);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.ShowMinimizeButton = false;
            this.titleBar1.Size = new System.Drawing.Size(104, 28);
            this.titleBar1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonName,
            this.LeaveDatesString,
            this.TotalLeaveDays,
            this.AssignedShiftsString,
            this.LeaveDates,
            this.AssignedShifts,
            this.WeekdayShifts,
            this.WeekendShifts});
            this.dataGridView1.Location = new System.Drawing.Point(11, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 380);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // PersonName
            // 
            this.PersonName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PersonName.HeaderText = "Name";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            // 
            // LeaveDatesString
            // 
            this.LeaveDatesString.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LeaveDatesString.HeaderText = "Leave Dates";
            this.LeaveDatesString.Name = "LeaveDatesString";
            this.LeaveDatesString.ReadOnly = true;
            this.LeaveDatesString.Width = 86;
            // 
            // TotalLeaveDays
            // 
            this.TotalLeaveDays.HeaderText = "Total Leave";
            this.TotalLeaveDays.Name = "TotalLeaveDays";
            this.TotalLeaveDays.ReadOnly = true;
            // 
            // AssignedShiftsString
            // 
            this.AssignedShiftsString.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AssignedShiftsString.HeaderText = "Assigned Shifts";
            this.AssignedShiftsString.Name = "AssignedShiftsString";
            this.AssignedShiftsString.ReadOnly = true;
            this.AssignedShiftsString.Width = 96;
            // 
            // LeaveDates
            // 
            this.LeaveDates.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LeaveDates.HeaderText = "LeaveDates";
            this.LeaveDates.Name = "LeaveDates";
            this.LeaveDates.ReadOnly = true;
            this.LeaveDates.Visible = false;
            // 
            // AssignedShifts
            // 
            this.AssignedShifts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AssignedShifts.HeaderText = "AssignedShifts";
            this.AssignedShifts.Name = "AssignedShifts";
            this.AssignedShifts.ReadOnly = true;
            this.AssignedShifts.Visible = false;
            // 
            // WeekdayShifts
            // 
            this.WeekdayShifts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WeekdayShifts.HeaderText = "Weekday";
            this.WeekdayShifts.Name = "WeekdayShifts";
            this.WeekdayShifts.ReadOnly = true;
            this.WeekdayShifts.Width = 78;
            // 
            // WeekendShifts
            // 
            this.WeekendShifts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WeekendShifts.HeaderText = "Weekend";
            this.WeekendShifts.Name = "WeekendShifts";
            this.WeekendShifts.ReadOnly = true;
            this.WeekendShifts.Width = 79;
            // 
            // frmAddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddPerson";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_titlebar.ResumeLayout(false);
            this.panel_titlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_titlebar;
        private System.Windows.Forms.Label label4;
        private Button_Control.TitleBar titleBar1;
        private CustomControls.RJControls.RJButton btn_continue;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_total;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton btn_assign;
        private CustomControls.RJControls.RJButton btn_download;
        private CustomControls.RJControls.RJButton btn_reset;
        private CustomControls.RJControls.RJButton rjButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveDatesString;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLeaveDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedShiftsString;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveDates;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedShifts;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeekdayShifts;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeekendShifts;
        private System.Windows.Forms.ProgressBar progressBar1;
        private CustomControls.RJControls.RJButton btn_holidays;
        private System.Windows.Forms.Label label_holidays;
        private System.Windows.Forms.Label label_shift_total;
        private System.Windows.Forms.Label label_shift_assign;
        private CustomControls.RJControls.RJButton btn_date;
        private CustomControls.RJControls.RJButton btn_clear;
    }
}