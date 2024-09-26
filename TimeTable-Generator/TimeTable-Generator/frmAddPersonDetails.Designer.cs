namespace TimeTable_Generator
{
    partial class frmAddPersonDetails
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
            this.btn_add = new CustomControls.RJControls.RJButton();
            this.tx_date = new CustomControls.RJControls.RJTextBox();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.btn_save = new CustomControls.RJControls.RJButton();
            this.btn_add_leave = new CustomControls.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list_leavedates = new System.Windows.Forms.ListBox();
            this.tx_name = new CustomControls.RJControls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.titleBar1 = new Button_Control.TitleBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.tx_date);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_add_leave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.list_leavedates);
            this.panel1.Controls.Add(this.tx_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 298);
            this.panel1.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LightBlue;
            this.btn_add.BackgroundColor = System.Drawing.Color.LightBlue;
            this.btn_add.BorderColor = System.Drawing.Color.Black;
            this.btn_add.BorderRadius = 0;
            this.btn_add.BorderSize = 1;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(29, 189);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(141, 25);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Add Leave Date";
            this.btn_add.TextColor = System.Drawing.Color.Black;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tx_date
            // 
            this.tx_date.BackColor = System.Drawing.SystemColors.Window;
            this.tx_date.BorderColor = System.Drawing.Color.MidnightBlue;
            this.tx_date.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tx_date.BorderRadius = 0;
            this.tx_date.BorderSize = 2;
            this.tx_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tx_date.Location = new System.Drawing.Point(29, 147);
            this.tx_date.Margin = new System.Windows.Forms.Padding(4);
            this.tx_date.Multiline = false;
            this.tx_date.Name = "tx_date";
            this.tx_date.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tx_date.PasswordChar = false;
            this.tx_date.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tx_date.PlaceholderText = "";
            this.tx_date.ReadOnly = false;
            this.tx_date.Size = new System.Drawing.Size(140, 35);
            this.tx_date.TabIndex = 17;
            this.tx_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tx_date.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tx_date.Texts = "";
            this.tx_date.UnderlinedStyle = false;
            this.tx_date.VScroll = true;
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
            this.rjButton1.Location = new System.Drawing.Point(494, 167);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(98, 41);
            this.rjButton1.TabIndex = 16;
            this.rjButton1.Text = "Delete Date";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_save.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.btn_save.BorderColor = System.Drawing.Color.Black;
            this.btn_save.BorderRadius = 0;
            this.btn_save.BorderSize = 1;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(494, 214);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 52);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "Save";
            this.btn_save.TextColor = System.Drawing.Color.Black;
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_add_leave
            // 
            this.btn_add_leave.BackColor = System.Drawing.Color.LightBlue;
            this.btn_add_leave.BackgroundColor = System.Drawing.Color.LightBlue;
            this.btn_add_leave.BorderColor = System.Drawing.Color.Black;
            this.btn_add_leave.BorderRadius = 0;
            this.btn_add_leave.BorderSize = 1;
            this.btn_add_leave.FlatAppearance.BorderSize = 0;
            this.btn_add_leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_leave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_leave.ForeColor = System.Drawing.Color.Black;
            this.btn_add_leave.Location = new System.Drawing.Point(494, 118);
            this.btn_add_leave.Name = "btn_add_leave";
            this.btn_add_leave.Size = new System.Drawing.Size(98, 43);
            this.btn_add_leave.TabIndex = 14;
            this.btn_add_leave.Text = "Add Leave Date";
            this.btn_add_leave.TextColor = System.Drawing.Color.Black;
            this.btn_add_leave.UseVisualStyleBackColor = false;
            this.btn_add_leave.Click += new System.EventHandler(this.btn_add_leave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Leave Dates :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name :";
            // 
            // list_leavedates
            // 
            this.list_leavedates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_leavedates.FormattingEnabled = true;
            this.list_leavedates.ItemHeight = 20;
            this.list_leavedates.Location = new System.Drawing.Point(211, 109);
            this.list_leavedates.Name = "list_leavedates";
            this.list_leavedates.Size = new System.Drawing.Size(250, 164);
            this.list_leavedates.TabIndex = 1;
            // 
            // tx_name
            // 
            this.tx_name.BackColor = System.Drawing.SystemColors.Window;
            this.tx_name.BorderColor = System.Drawing.Color.MidnightBlue;
            this.tx_name.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tx_name.BorderRadius = 0;
            this.tx_name.BorderSize = 2;
            this.tx_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tx_name.Location = new System.Drawing.Point(211, 49);
            this.tx_name.Margin = new System.Windows.Forms.Padding(4);
            this.tx_name.Multiline = false;
            this.tx_name.Name = "tx_name";
            this.tx_name.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tx_name.PasswordChar = false;
            this.tx_name.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tx_name.PlaceholderText = "";
            this.tx_name.ReadOnly = false;
            this.tx_name.Size = new System.Drawing.Size(381, 35);
            this.tx_name.TabIndex = 0;
            this.tx_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tx_name.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tx_name.Texts = "";
            this.tx_name.UnderlinedStyle = false;
            this.tx_name.VScroll = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.titleBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 30);
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
            this.label4.Size = new System.Drawing.Size(170, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Add Person Details";
            // 
            // titleBar1
            // 
            this.titleBar1.CloseMessage = "Exit Application?";
            this.titleBar1.CloseTitle = "Exit";
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.titleBar1.EnableDialog = false;
            this.titleBar1.Location = new System.Drawing.Point(520, 0);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.ShowMinimizeButton = false;
            this.titleBar1.Size = new System.Drawing.Size(104, 30);
            this.titleBar1.TabIndex = 0;
            // 
            // frmAddPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 298);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddPersonDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddPersonDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJTextBox tx_name;
        private System.Windows.Forms.ListBox list_leavedates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton btn_add_leave;
        private CustomControls.RJControls.RJButton btn_save;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private Button_Control.TitleBar titleBar1;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton btn_add;
        private CustomControls.RJControls.RJTextBox tx_date;
    }
}