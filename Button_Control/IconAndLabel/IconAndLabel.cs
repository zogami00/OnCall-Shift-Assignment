using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_Control.IconAndLabel
{
    [DefaultEvent("Click")]
    public partial class IconAndLabel : UserControl
    {
        private Color originalBackColor;
        public IconAndLabel()
        {
            InitializeComponent();

            pictureBox1.DoubleClick += OnControlDoubleClick;
            label1.DoubleClick += OnControlDoubleClick;
            pictureBox1.Click += OnControlClick;
            label1.Click += OnControlClick;

            // Save the original back color
            originalBackColor = this.BackColor;

            // Subscribe to MouseEnter and MouseLeave events for highlighting
            this.MouseEnter += OnMouseEnterHighlight;
            this.MouseLeave += OnMouseLeaveHighlight;

            // Also subscribe the child controls if they need to highlight as well
            pictureBox1.MouseEnter += OnMouseEnterHighlight;
            pictureBox1.MouseLeave += OnMouseLeaveHighlight;
            label1.MouseEnter += OnMouseEnterHighlight;
            label1.MouseLeave += OnMouseLeaveHighlight;
        }

        // Property to set the image of the PictureBox
        public Image Icon
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

        // Property to set the text of the Label
        public string LabelText
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        // Property to set the alignment of the Label text
        public ContentAlignment TextAlign
        {
            get => label1.TextAlign;
            set => label1.TextAlign = value;
        }

        // You can also add properties for padding, font, etc.

        public Font LabelFont
        {
            get => label1.Font;
            set => label1.Font = value;
        }

        // Property to get or set the Font size of the Label
        public float FontSize
        {
            get => label1.Font.Size;
            set => label1.Font = new Font(label1.Font.FontFamily, value, label1.Font.Style);
        }

        // Property to get or set the Font style of the Label
        public FontStyle FontStyle
        {
            get => label1.Font.Style;
            set => label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size, value);
        }

        // Property to get or set the Font family of the Label
        public string FontFamily
        {
            get => label1.Font.FontFamily.Name;
            set => label1.Font = new Font(new FontFamily(value), label1.Font.Size, label1.Font.Style);
        }
        private Color hoverColor = Color.LightBlue; // Default hover color
        public Color HoverColor
        {
            get => hoverColor;
            set => hoverColor = value;
        }

        // Property to set the original back color of the control
        public Color OriginalBackColor
        {
            get => originalBackColor;
            set
            {
                originalBackColor = value;
                this.BackColor = value;
            }
        }

        #region Events

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);
       
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
        private void OnControlClick(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        // Common handler for PictureBox and Label DoubleClick events
        private void OnControlDoubleClick(object sender, EventArgs e)
        {
            this.OnDoubleClick(e);
        }

        // Highlight the control when the mouse enters
        private void OnMouseEnterHighlight(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue; // or any color you'd like for the highlight
        }

        // Remove the highlight when the mouse leaves
        private void OnMouseLeaveHighlight(object sender, EventArgs e)
        {
            this.BackColor = originalBackColor;
        }



        #endregion
    }

}
