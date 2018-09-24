using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USER_CONTROLS
{
    public partial class Picture_Box_Perso : System.Windows.Forms.PictureBox
    {
        private string message_ = "message";
        public ToolTip tooltip_ = new ToolTip();
        

        [Category("Configuration"), Browsable(true), Description("Get ToolTip Message")]
        public String Message
        {
            get
            {return message_; }
            set
            { message_ = value;}
        }
        public Picture_Box_Perso()
        {
            InitializeComponent();
            tooltip_.UseAnimation= true;
            // Set up the delays for the ToolTip.
            tooltip_.AutoPopDelay = 5000;
            tooltip_.InitialDelay = 1000;
            tooltip_.ReshowDelay = 500;
        }

        public Picture_Box_Perso(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        private void Picture_Box_Perso_MouseEnter(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X + 1, this.Location.Y + 1);
            // tooltip_.ShowAlways = true;
            tooltip_.Show(message_, this, 30, 30);            
        }

        private void Picture_Box_Perso_MouseLeave(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X - 1, this.Location.Y - 1);
            tooltip_.Hide(this);
        }
    }
}
