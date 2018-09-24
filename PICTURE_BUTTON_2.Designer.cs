namespace USER_CONTROLS
{
    partial class PICTURE_BUTTON_2
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
            this.PICTUREBOX = new System.Windows.Forms.PictureBox();
            this.BUTTON = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PICTUREBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // PICTUREBOX
            // 
            this.PICTUREBOX.BackColor = System.Drawing.Color.Transparent;
            this.PICTUREBOX.ImageLocation = "";
            this.PICTUREBOX.Location = new System.Drawing.Point(0, 0);
            this.PICTUREBOX.Name = "PICTUREBOX";
            this.PICTUREBOX.Size = new System.Drawing.Size(30, 30);
            this.PICTUREBOX.TabIndex = 2;
            this.PICTUREBOX.TabStop = false;
            // 
            // BUTTON
            // 
            this.BUTTON.BackColor = System.Drawing.Color.Transparent;
            this.BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON.Location = new System.Drawing.Point(31, 0);
            this.BUTTON.Name = "BUTTON";
            this.BUTTON.Size = new System.Drawing.Size(76, 30);
            this.BUTTON.TabIndex = 1;
            this.BUTTON.Text = "BUTTON";
            this.BUTTON.UseVisualStyleBackColor = true;
            this.BUTTON.Click += new System.EventHandler(this.BUTTON_Click);
            this.BUTTON.MouseEnter += new System.EventHandler(this.BUTTON_MouseEnter);
            this.BUTTON.MouseLeave += new System.EventHandler(this.BUTTON_MouseLeave);
            // 
            // PICTURE_BUTTON_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PICTUREBOX);
            this.Controls.Add(this.BUTTON);
            this.Name = "PICTURE_BUTTON_2";
            this.Size = new System.Drawing.Size(115, 28);
            ((System.ComponentModel.ISupportInitialize)(this.PICTUREBOX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PICTUREBOX;
        private System.Windows.Forms.Button BUTTON;

    }
}
