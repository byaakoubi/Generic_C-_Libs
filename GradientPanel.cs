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
    public partial class GradientPanel : System.Windows.Forms.Panel
    {
        private Color ColorA = Color.LightSteelBlue;
        private Color ColorB = Color.White;
        private LinearGradientMode GradientFillStyle = LinearGradientMode.ForwardDiagonal;
        private Brush gradientBrush;

        public GradientPanel()
        {
            handlerGradientChanged = new EventHandler(GradientChanged);
            ResizeRedraw = true;
        }
        private EventHandler handlerGradientChanged;
        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
        {
            gradientBrush = new LinearGradientBrush(ClientRectangle, ColorA, ColorB, GradientFillStyle);
            e.Graphics.FillRectangle(gradientBrush, ClientRectangle);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (gradientBrush != null) gradientBrush.Dispose();
            }
            base.Dispose(disposing);
        }
        protected override void OnScroll(ScrollEventArgs se)
        {
            Invalidate();
        }
        private void GradientChanged(object sender, EventArgs e)
        {
            if (gradientBrush != null) gradientBrush.Dispose();
            gradientBrush = null;
            Invalidate();
        }

        //
        public GradientPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
