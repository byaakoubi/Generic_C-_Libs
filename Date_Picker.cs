using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USER_CONTROLS
{
    public partial class Date_Picker : System.Windows.Forms.MaskedTextBox
    {

        private Boolean Enter_Key = true;
        public Boolean Enter_Key_Activated
        {
            get { return Enter_Key; }
            set
            {
                Enter_Key = value;
                this.Text = "";
            }
        }


        public Date_Picker()
        {
            InitializeComponent();
        }

        public Date_Picker(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        private void Date_Picker_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((Enter_Key == true) && (e.KeyCode == Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void Date_Picker_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Parse(this.Text);
            }
            catch
            {
                try
                {
                    this.Text = this.Text.Substring(0, 6) + DateTime.Now.ToString().Substring(6, 4);
                    DateTime date = DateTime.Parse(this.Text);
                }
                catch
                {
                    this.Text = DateTime.Now.ToString().Substring(0, 10);
                }
            }
            if (this.Text.Length != 10)
                this.Text = this.Text.Substring(0, 6) + DateTime.Now.ToString().Substring(6, 4);

        }

        private void Date_Picker_Click(object sender, EventArgs e)
        {
            this.Select();
        }
    }
}
