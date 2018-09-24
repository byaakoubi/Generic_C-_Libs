using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USER_CONTROLS
{
    public partial class ComboBox : System.Windows.Forms.ComboBox
    {
        public ComboBox()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        public ComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int buttonWidth = SystemInformation.VerticalScrollBarWidth;
            Color highColor = SystemColors.ControlLightLight;
            Color lowColor = SystemColors.ControlDark;
            Rectangle itemRect = new Rectangle(this.Width - buttonWidth, 0, buttonWidth, this.Height);

            //Create the brushes.            
            LinearGradientBrush gradientBrush = new LinearGradientBrush(itemRect, highColor,
                    lowColor, LinearGradientMode.Vertical);

            //Fill the rectangle background.
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(gradientBrush, itemRect);
            gradientBrush.Dispose();

            //Draw the button outline.
            Pen outlinePen = new Pen(SystemColors.ButtonShadow, 2.0f);
            e.Graphics.DrawRectangle(outlinePen, itemRect.X, itemRect.Y, itemRect.Width - 2, itemRect.Height - 2);
            outlinePen.Dispose();

            //Draw the arrow.
            SolidBrush arrowBrush = new SolidBrush(Color.Red);
            Point[] points = new Point[3];
            points[0] = new Point(this.Width - (int)((double)itemRect.Width * .125) - 2, (int)((double)itemRect.Height * .333));
            points[1] = new Point(this.Width - (int)((double)itemRect.Width * .875) - 2, (int)((double)itemRect.Height * .333));
            points[2] = new Point(this.Width - (int)((double)itemRect.Width * .5) - 2, (int)((double)itemRect.Height * .666));

            e.Graphics.FillPolygon(arrowBrush, points);
            arrowBrush.Dispose();
        } 

    }
}
