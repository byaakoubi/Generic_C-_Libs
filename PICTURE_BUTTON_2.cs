using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace USER_CONTROLS
{
    public partial class PICTURE_BUTTON_2 : UserControl
    {
        public PICTURE_BUTTON_2()
        {
            InitializeComponent();
            BUTTON.TabStop = false;
            BUTTON.FlatStyle = FlatStyle.Flat;
            BUTTON.FlatAppearance.BorderSize = 0;
            BUTTON.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
        [Category("Configuration"), Browsable(true), Description("Get Set Title")]
        public String Title
        {
            get
            {
                return this.BUTTON.Text;
            }
            set
            {
                this.BUTTON.Text = value;
            }
        }

        // [Category("Configuration"), Browsable(true), Description("Get Set Image")]
        public Image Picture_Image
        {
            get
            {
                return this.PICTUREBOX.Image;
            }
            set
            {
                //this.Picture_Image = value;
                Bitmap bmp = new Bitmap(value);
                if (bmp != null)
                {
                    this.PICTUREBOX.Image = (Image)bmp;
                }
            }
        }
        // Déclaration des délégués
        public delegate void ButtonClickHandler(object sender, EventArgs e);
        // Déclaration des évènements qui utilisent ces délégués
        [Category("Configuration"), Browsable(true), Description("Evènement associé au bouton")]
        public event ButtonClickHandler BUTTON_Click_handler;
        protected virtual void OnButtonClick(EventArgs e)
        {
            if (BUTTON_Click_handler != null)
            {
                BUTTON_Click_handler(this, e);
            }
        }

        private void BUTTON_Click(object sender, EventArgs e)
        {
            // On lance nos méthodes
            OnButtonClick(e);
        }

        private void BUTTON_MouseEnter(object sender, EventArgs e)
        {
            //BUTTON.BackColor = SystemColors.GradientInactiveCaption;
            BUTTON.Location = new Point(BUTTON.Location.X, BUTTON.Location.Y + 2);
        }

        private void BUTTON_MouseLeave(object sender, EventArgs e)
        {
            //BUTTON.BackColor = Color.Transparent;
            BUTTON.Location = new Point(BUTTON.Location.X, BUTTON.Location.Y - 2);
        }

        Color _color1 = Color.White;
        Color _color2 = Color.FromArgb(224, 224, 224);

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Transparent, ClientRectangle);
            Rectangle buttom_rect = new Rectangle(new Point(BUTTON.Location.X + BUTTON.Width, BUTTON.Location.Y), BUTTON.Size);
            //Brush linearGradientBrush= new LinearGradientBrush(new Point(BUTTON.Location.X, BUTTON.Location.Y), new Point(BUTTON.Location.X + BUTTON.Width, BUTTON.Location.Y), _color1, _color2, LinearGradientMode.Vertical);
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(buttom_rect, _color1, _color2, LinearGradientMode.Vertical);
            g.FillRectangle(linearGradientBrush, new Rectangle(BUTTON.Location.X, BUTTON.Location.Y, BUTTON.Width, BUTTON.Height));

            linearGradientBrush.Dispose();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle borderRect = new Rectangle(new Point(BUTTON.Location.X,BUTTON.Location.Y),BUTTON.Size) ;
            ControlPaint.DrawBorder(e.Graphics, borderRect, SystemColors.ActiveBorder, ButtonBorderStyle.Solid);
        }

    }
}