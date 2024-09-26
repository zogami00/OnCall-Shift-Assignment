namespace Button_Control
{
    partial class TitleBar
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_min = new CustomControls.RJControls.RJButton();
            this.btn_close = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.Transparent;
            this.btn_min.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_min.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_min.BorderRadius = 5;
            this.btn_min.BorderSize = 0;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.ForeColor = System.Drawing.Color.Black;
            this.btn_min.Location = new System.Drawing.Point(47, 1);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(27, 25);
            this.btn_min.TabIndex = 17;
            this.btn_min.Text = "-";
            this.btn_min.TextColor = System.Drawing.Color.Black;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_close.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_close.BorderRadius = 5;
            this.btn_close.BorderSize = 0;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(70, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(27, 25);
            this.btn_close.TabIndex = 16;
            this.btn_close.Text = "X";
            this.btn_close.TextColor = System.Drawing.Color.Black;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // TitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_close);
            this.Name = "TitleBar";
            this.Size = new System.Drawing.Size(104, 28);
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.RJControls.RJButton btn_close;
        private CustomControls.RJControls.RJButton btn_min;
    }
}
