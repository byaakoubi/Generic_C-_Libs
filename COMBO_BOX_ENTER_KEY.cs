using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace USER_CONTROLS
{
    public partial class COMBO_BOX_ENTER_KEY : UserControl
    {
        public COMBO_BOX_ENTER_KEY()
        {
            InitializeComponent();
        }

        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design",
            "System.Drawing.Design.UITypeEditor, System.Drawing")]
        [Category("Configuration"), Browsable(true), Description("Get Set Text")]
        public ComboBox.ObjectCollection COMBO_BOX_Items
        {
            get
            {
                return this.COMBO_BOX.Items;
            }
            set
            {
                for (int i = 0; i < value.Count; i++)
                {
                    COMBO_BOX.Items.Add(value[i]);
                }
            }
        }


        [Category("Configuration"), Browsable(true), Description("Get Set Text Box Text")]
        public int COMBO_BOX_Width
        {
            get
            {
                return this.COMBO_BOX.Width;
            }
            set
            {
                this.COMBO_BOX.Width = value;
            }
        }

        private void COMBO_BOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");

            }
        }
    }
}
