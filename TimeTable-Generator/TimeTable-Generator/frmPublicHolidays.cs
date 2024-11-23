using CustomControls.RJControls;
using IMS_Project.Class.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable_Generator
{
    public partial class frmPublicHolidays : Form
    {
        private List<DateTime> publicHolidays;
        public frmPublicHolidays(List<DateTime> publicHolidays)
        {
            InitializeComponent();
            this.publicHolidays = publicHolidays;
            this.Load += FrmPublicHolidays_Load;
            titleBar1.SetParentForm(this);
            TitleBarPanelStyler.ApplyTitleBarPanelStyle(panel_titlebar, this);

        }

        private void FrmPublicHolidays_Load(object sender, EventArgs e)
        {
            list_publicholidays.Items.Clear();

            if(publicHolidays!= null)
            {
                foreach (DateTime date in publicHolidays)
                {
                    list_publicholidays.Items.Add(date.Date);
                }
            }
            
           
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if(publicHolidays != null)
            {
                publicHolidays.Clear();
            }            

            foreach (var item in list_publicholidays.Items)
            {
                DateTime preferred = DateTime.Parse(item.ToString());
                publicHolidays.Add(preferred.Date);
            }
            this.Close();
        }

        private void FocusAndSelectTextBeforeFirstSlash(TextBox textBox)
        {
            // Focus the TextBox
            textBox.Focus();

            // Find the index of the first '/'
            int slashIndex = textBox.Text.IndexOf('/');

            // If a slash is found, select the text before the first one
            if (slashIndex > 0)
            {
                textBox.Select(0, slashIndex);
            }
            else
            {
                // Optionally handle the case where no slash is found
                textBox.SelectAll();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tx_date.Text))
            {
                list_publicholidays.Items.Add(tx_date.Text);
                FocusAndSelectTextBeforeFirstSlash(tx_date);
            }
            
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (list_publicholidays.SelectedItem != null)
            {
                // Remove the selected item
                list_publicholidays.Items.Remove(list_publicholidays.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a leave date to delete.");
            }
        }
    }
}
