using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace USER_CONTROLS
{
    public partial class TEXT_BOX_ENTER_KEY : UserControl
    {
        public Boolean Numeric = false;
        public TEXT_BOX_ENTER_KEY()
        {
            InitializeComponent();
        }
        [Category("Configuration"), DefaultValue(""), Browsable(true), Description("Get Set Text Box Text")]
        public String Text
        {
            get
            {
                return this.TEXT_BOX.Text;
            }
            set
            {
                this.TEXT_BOX.Text = value;
            }
        }
        [Category("Configuration"), DefaultValue(false), Browsable(true), Description("Get Set Numeric")]
        public Boolean Is_Numeric
        {
            get
            {
                return this.Numeric;
            }
            set
            {
                this.Numeric = value;
            }
        }

        private void TEXT_BOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");

            }
        }

        private void TEXT_BOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar) || (e.KeyChar) == '.'))
            {
                if (e.KeyChar == '²') e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar)) e.Handled = false; // vérifier si le caractère tapé est un controle (backspace, enter,...)
            else if (Is_Numeric == true)
                e.Handled = true;
        }
      
    }
}
