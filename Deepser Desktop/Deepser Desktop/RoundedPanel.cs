using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser_Desktop
{
    public class RoundedPanel : Panel
    {
        private int borderRadius = 10;

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    Invalidate(); // Redraw the control when the BorderRadius changes
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a GraphicsPath to define the rounded shape
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = BorderRadius;
                int diameter = radius * 2;

                // Define the rounded rectangle shape
                path.AddArc(0, 0, diameter, diameter, 180, 90); // Top-left corner
                path.AddArc(Width - diameter - 1, 0, diameter, diameter, 270, 90); // Top-right corner
                path.AddArc(Width - diameter - 1, Height - diameter - 1, diameter, diameter, 0, 90); // Bottom-right corner
                path.AddArc(0, Height - diameter - 1, diameter, diameter, 90, 90); // Bottom-left corner
                path.CloseFigure();

                // Set the Region property to make the control display the rounded shape
                Region = new Region(path);
            }
        }
    }
}
