namespace USER_CONTROLS
{
    partial class PICTURE_BUTTON_3
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
            this.BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BUTTON
            // 
            this.BUTTON.BackColor = System.Drawing.Color.Transparent;
            this.BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON.Location = new System.Drawing.Point(3, 0);
            this.BUTTON.Name = "BUTTON";
            this.BUTTON.Size = new System.Drawing.Size(80, 30);
            this.BUTTON.TabIndex = 1;
            this.BUTTON.Text = "BUTTON";
            this.BUTTON.UseVisualStyleBackColor = false;
            this.BUTTON.Click += new System.EventHandler(this.BUTTON_Click);
            this.BUTTON.MouseEnter += new System.EventHandler(this.BUTTON_MouseEnter);
            this.BUTTON.MouseLeave += new System.EventHandler(this.BUTTON_MouseLeave);
            // 
            // PICTURE_BUTTON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.BUTTON);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PICTURE_BUTTON";
            this.Size = new System.Drawing.Size(88, 33);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BUTTON;
    }
}
