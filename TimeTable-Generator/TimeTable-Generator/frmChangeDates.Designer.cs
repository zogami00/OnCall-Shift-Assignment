namespace TimeTable_Generator
{
    partial class frmChangeDates
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.titleBar1 = new Button_Control.TitleBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date_start = new Button_Control.DTP.RJDatePicker();
            this.date_end = new Button_Control.DTP.RJDatePicker();
            this.btn_continue = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_continue);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.date_start);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.date_end);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 175);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.titleBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 30);
            this.panel2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label4.Size = new System.Drawing.Size(217, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Change Timetable Dates";
            // 
            // titleBar1
            // 
            this.titleBar1.CloseMessage = "Exit Application?";
            this.titleBar1.CloseTitle = "Exit";
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.titleBar1.EnableDialog = true;
            this.titleBar1.Location = new System.Drawing.Point(483, 0);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.ShowMinimizeButton = false;
            this.titleBar1.Size = new System.Drawing.Size(104, 30);
            this.titleBar1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start Date";
            // 
            // date_start
            // 
            this.date_start.BorderColor = System.Drawing.Color.Black;
            this.date_start.BorderSize = 1;
            this.date_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.date_start.Location = new System.Drawing.Point(16, 72);
            this.date_start.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(251, 35);
            this.date_start.SkinColor = System.Drawing.Color.PaleGreen;
            this.date_start.TabIndex = 5;
            this.date_start.TextColor = System.Drawing.Color.Black;
            // 
            // date_end
            // 
            this.date_end.BorderColor = System.Drawing.Color.Black;
            this.date_end.BorderSize = 1;
            this.date_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.date_end.Location = new System.Drawing.Point(319, 72);
            this.date_end.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(251, 35);
            this.date_end.SkinColor = System.Drawing.Color.Pink;
            this.date_end.TabIndex = 4;
            this.date_end.TextColor = System.Drawing.Color.Black;
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.Color.LightCoral;
            this.btn_continue.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btn_continue.BorderColor = System.Drawing.Color.Black;
            this.btn_continue.BorderRadius = 0;
            this.btn_continue.BorderSize = 1;
            this.btn_continue.FlatAppearance.BorderSize = 0;
            this.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continue.ForeColor = System.Drawing.Color.Black;
            this.btn_continue.Location = new System.Drawing.Point(208, 122);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(150, 40);
            this.btn_continue.TabIndex = 8;
            this.btn_continue.Text = "Continue";
            this.btn_continue.TextColor = System.Drawing.Color.Black;
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // frmChangeDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 175);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangeDates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangeDates";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private Button_Control.TitleBar titleBar1;
        private System.Windows.Forms.Label label2;
        private Button_Control.DTP.RJDatePicker date_start;
        private System.Windows.Forms.Label label1;
        private Button_Control.DTP.RJDatePicker date_end;
        private CustomControls.RJControls.RJButton btn_continue;
    }
}