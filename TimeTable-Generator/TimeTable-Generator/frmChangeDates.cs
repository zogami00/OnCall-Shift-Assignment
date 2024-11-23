using DocumentFormat.OpenXml.Wordprocessing;
using IMS_Project.Class.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable_Generator
{
    public partial class frmChangeDates : Form
    {
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public frmChangeDates(DateTime startdate, DateTime enddate)
        {
            InitializeComponent();
            titleBar1.SetParentForm(this);
            TitleBarPanelStyler.ApplyTitleBarPanelStyle(panel_titlebar, this);

            this.StartDate = startdate;
            this.EndDate = enddate;
            this.Load += FrmChangeDates_Load;
        }

        private void FrmChangeDates_Load(object sender, EventArgs e)
        {
            date_start.Value = StartDate;
            date_end.Value = EndDate;
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Update timetable from {date_start.Value.ToString("d")} to {date_end.Value.ToString("d")}?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                StartDate = date_start.Value.Date;
                EndDate = date_end.Value.Date;

                this.Close();
            }

            
        }
    }
}
