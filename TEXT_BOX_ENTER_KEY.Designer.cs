namespace USER_CONTROLS
{
    partial class TEXT_BOX_ENTER_KEY
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
            this.TEXT_BOX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TEXT_BOX
            // 
            this.TEXT_BOX.Location = new System.Drawing.Point(0, 0);
            this.TEXT_BOX.Name = "TEXT_BOX";
            this.TEXT_BOX.Size = new System.Drawing.Size(289, 20);
            this.TEXT_BOX.TabIndex = 0;
            this.TEXT_BOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TEXT_BOX_KeyDown);
            this.TEXT_BOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TEXT_BOX_KeyPress);
            // 
            // TEXT_BOX_ENTER_KEY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TEXT_BOX);
            this.Name = "TEXT_BOX_ENTER_KEY";
            this.Size = new System.Drawing.Size(289, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TEXT_BOX;
    }
}
