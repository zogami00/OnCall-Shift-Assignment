namespace TimeTable_Generator
{
    partial class frmLeaveDate_helper
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
            this.btn_save = new CustomControls.RJControls.RJButton();
            this.date_select = new Button_Control.DTP.RJDatePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.date_select);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 136);
            this.panel1.TabIndex = 0;
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
            this.btn_save.Location = new System.Drawing.Point(79, 83);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(110, 33);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Save";
            this.btn_save.TextColor = System.Drawing.Color.Black;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // date_select
            // 
            this.date_select.BorderColor = System.Drawing.Color.Black;
            this.date_select.BorderSize = 1;
            this.date_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.date_select.Location = new System.Drawing.Point(29, 25);
            this.date_select.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_select.Name = "date_select";
            this.date_select.Size = new System.Drawing.Size(224, 35);
            this.date_select.SkinColor = System.Drawing.Color.Pink;
            this.date_select.TabIndex = 1;
            this.date_select.TextColor = System.Drawing.Color.Black;
            // 
            // frmLeaveDate_helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 136);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLeaveDate_helper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmLeaveDate_helper";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Button_Control.DTP.RJDatePicker date_select;
        private CustomControls.RJControls.RJButton btn_save;
    }
}