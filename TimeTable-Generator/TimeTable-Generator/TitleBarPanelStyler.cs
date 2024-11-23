using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS_Project.Class.Styles
{
    public class TitleBarPanelStyler
    {
        public static void ApplyTitleBarPanelStyle(Panel panel, Form form)
        {
            // Add event handlers to the panel itself
            panel.MouseDown += (sender, e) => Panel_MouseDown(sender, e);
            panel.MouseMove += (sender, e) => Panel_MouseMove(sender, e, form);
            panel.MouseUp += (sender, e) => Panel_MouseUp(sender, e);

            panel.BorderStyle = BorderStyle.FixedSingle;
            // Add event handlers to all child controls within the panel
            foreach (Control control in panel.Controls)
            {
                control.MouseDown += (sender, e) => Panel_MouseDown(sender, e);
                control.MouseMove += (sender, e) => Panel_MouseMove(sender, e, form);
                control.MouseUp += (sender, e) => Panel_MouseUp(sender, e);
            }
        }

        private static bool isDragging = false;
        private static Point startPoint = new Point(0, 0);

        private static void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private static void Panel_MouseMove(object sender, MouseEventArgs e, Form form)
        {
            if (isDragging)
            {
                // Calculate the new position of the form
                Point newPosition = new Point(e.X - startPoint.X, e.Y - startPoint.Y);
                form.Location = new Point(form.Location.X + newPosition.X, form.Location.Y + newPosition.Y);
            }
        }

        private static void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop dragging
            isDragging = false;
        }
    }
}