using System;
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
    public partial class frmAddPersonDetails : Form
    {
        private List<Person> people;
        Person PersonToUpdate;
        public frmAddPersonDetails(List<Person> people)
        {
            InitializeComponent();
            this.people = people;
            titleBar1.SetParentForm(this);
            btn_save.Click += btn_save_Click;
        }
        public frmAddPersonDetails(List<Person> people,Person personToUpdate)
        {
            InitializeComponent();
            this.people = people;
            this.PersonToUpdate = personToUpdate;
            this.Load += FrmAddPersonDetails_Load;
            btn_save.Click += Btn_save_Click_update;
            titleBar1.SetParentForm(this);

        }

        private void Btn_save_Click_update(object sender, EventArgs e)
        {
            PersonToUpdate.LeaveDates.Clear();
            PersonToUpdate.Name = tx_name.Texts;
            // Loop through the items in the ListBox and update the LeaveDates list
            foreach (var item in list_leavedates.Items)
            {
                DateTime leaveDate = DateTime.Parse(item.ToString());
                PersonToUpdate.LeaveDates.Add(leaveDate.Date);
            }
            this.Close();
        }

        private void FrmAddPersonDetails_Load(object sender, EventArgs e)
        {
            tx_name.Texts = PersonToUpdate.Name;

            list_leavedates.Items.Clear();
            foreach (var leaveDate in PersonToUpdate.LeaveDates)
            {
                list_leavedates.Items.Add(leaveDate.Date);
            }
        }

        private void btn_add_leave_Click(object sender, EventArgs e)
        {
            frmLeaveDate_helper date_Helper = new frmLeaveDate_helper(list_leavedates);
            date_Helper.FormClosed += Date_Helper_FormClosed;
            date_Helper.ShowDialog();
        }

        private void Date_Helper_FormClosed(object sender, FormClosedEventArgs e)
        {
            list_leavedates.Invalidate();
            list_leavedates.Update();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (list_leavedates.SelectedItem != null)
            {
                // Remove the selected item
                list_leavedates.Items.Remove(list_leavedates.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a leave date to delete.");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string name = tx_name.Texts;

            if (!string.IsNullOrEmpty(name))
            {
                // Create a new Person object
                Person newPerson = new Person(name);

                // Loop through the ListBox to add all leave dates

                foreach (var item in list_leavedates.Items)
                {
                    DateTime leaveDate = DateTime.Parse(item.ToString());
                    newPerson.LeaveDates.Add(leaveDate);
                }                              

                // Add the new person to the people list
                people.Add(newPerson);

                // Close the details form
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a name.");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            list_leavedates.Items.Add(tx_date.Texts);
        }
    }   
}
