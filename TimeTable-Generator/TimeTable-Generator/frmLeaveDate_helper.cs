using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable_Generator
{
    public partial class frmLeaveDate_helper : Form
    { // Import the SendMessage function from the User32.dll
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        // Constant for the DateTimePicker's dropdown message
        const uint DTM_FIRST = 0x1000;
        const uint DTM_CLOSEMONTHCAL = DTM_FIRST + 13;
        const uint DTM_OPENMONTHCAL = DTM_FIRST + 24;
        ListBox ListBox;


        public frmLeaveDate_helper(ListBox listBox)
        {
            InitializeComponent();
            this.ListBox = listBox;
            this.Load += FrmLeaveDate_helper_Load;
        }
        private void OpenDateTimePickerDropDown()
        {
            // Send the message to open the DateTimePicker dropdown
            SendMessage(date_select.Handle, DTM_OPENMONTHCAL, IntPtr.Zero, IntPtr.Zero);
        }
        private void FrmLeaveDate_helper_Load(object sender, EventArgs e)
        {
           OpenDateTimePickerDropDown();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DateTime leaveDate = date_select.Value;

            // Add the leave date to the ListBox for displaying multiple leave dates
            ListBox.Items.Add(leaveDate.ToString("d"));
            this.Close();
        }
    }
}
