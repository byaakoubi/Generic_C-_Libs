namespace USER_CONTROLS
{
    partial class COMBO_BOX_ENTER_KEY
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.COMBO_BOX = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // COMBO_BOX
            // 
            this.COMBO_BOX.FormattingEnabled = true;
            this.COMBO_BOX.Location = new System.Drawing.Point(0, 0);
            this.COMBO_BOX.Name = "COMBO_BOX";
            this.COMBO_BOX.Size = new System.Drawing.Size(114, 21);
            this.COMBO_BOX.TabIndex = 0;
            this.COMBO_BOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.COMBO_BOX_KeyDown);
            // 
            // COMBO_BOX_ENTER_KEY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.COMBO_BOX);
            this.Name = "COMBO_BOX_ENTER_KEY";
            this.Size = new System.Drawing.Size(296, 21);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox COMBO_BOX;



    }
}
