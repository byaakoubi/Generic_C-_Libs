using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USER_CONTROLS
{
    public partial class Label_Click : System.Windows.Forms.Label
    {
        public Label_Click()
        {
            InitializeComponent();
        }

        public Label_Click(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void Label_Click_MouseEnter(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X, this.Location.Y + 1);
            this.ForeColor = SystemColors.Highlight;
        }

        private void Label_Click_MouseLeave(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X, this.Location.Y - 1);
            this.ForeColor = SystemColors.HotTrack;
        }
    }
}
