namespace USER_CONTROLS
{
    partial class Date_Picker
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
            this.SuspendLayout();
            // 
            // Date_Picker
            // 
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Click += new System.EventHandler(this.Date_Picker_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Date_Picker_KeyDown);
            this.Leave += new System.EventHandler(this.Date_Picker_Leave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
