using System;
using System.Windows.Forms;

namespace Button_Control
{
    public partial class TitleBar : UserControl
    {
        private Form parentForm;
        private bool DialogEnabled;
        public TitleBar()
        {
            InitializeComponent();
        }

        // Set the reference to the form
        public void SetParentForm(Form form)
        {
            parentForm = form;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if(DialogEnabled)
            {
                var result = MessageBox.Show(CloseMessage, CloseTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    parentForm?.Close();
                }
            }
            else { parentForm?.Close(); }
           

        }
        private bool enableDialog = true;
        public bool EnableDialog
        {
            get { return enableDialog; }
            set
            {
                enableDialog = value;
                DialogEnabled = enableDialog;
            }
        }



        private string closeMessage = "Exit Application?";
        public string CloseMessage
        {
            get { return closeMessage; }
            set { closeMessage = value; }
        }
        private string closeTitle = "Exit";
        public string CloseTitle
        {
            get { return closeTitle; }
            set { closeTitle = value; }
        }
        private void btn_min_Click(object sender, EventArgs e)
        {
            if (parentForm != null)
            {
                parentForm.WindowState = FormWindowState.Minimized;
            }
        }
        // Property to control the visibility of the minimize button
        private bool showMinimizeButton = true;
        public bool ShowMinimizeButton
        {
            get { return showMinimizeButton; }
            set
            {
                showMinimizeButton = value;
                btn_min.Visible = showMinimizeButton;
            }
        }
        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            btn_close.ForeColor = ForeColor;
            btn_min.ForeColor = ForeColor;
        }

    }

}

