namespace Bai2
{
    partial class FrmAbout
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNotepadVersion = new System.Windows.Forms.Label();
            this.lblNotepadAuthor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNotepadVersion
            // 
            this.lblNotepadVersion.AutoSize = true;
            this.lblNotepadVersion.Location = new System.Drawing.Point(171, 202);
            this.lblNotepadVersion.Name = "lblNotepadVersion";
            this.lblNotepadVersion.Size = new System.Drawing.Size(154, 13);
            this.lblNotepadVersion.TabIndex = 1;
            this.lblNotepadVersion.Text = "Version: Notepad Version 0.9.9";
            // 
            // lblNotepadAuthor
            // 
            this.lblNotepadAuthor.AutoSize = true;
            this.lblNotepadAuthor.Location = new System.Drawing.Point(193, 232);
            this.lblNotepadAuthor.Name = "lblNotepadAuthor";
            this.lblNotepadAuthor.Size = new System.Drawing.Size(107, 13);
            this.lblNotepadAuthor.TabIndex = 1;
            this.lblNotepadAuthor.Text = "Author: Danh Thanh ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bai2.Properties.Resources.windows105;
            this.pictureBox1.InitialImage = global::Bai2.Properties.Resources.windows105;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 254);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNotepadAuthor);
            this.Controls.Add(this.lblNotepadVersion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Notepad";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNotepadVersion;
        private System.Windows.Forms.Label lblNotepadAuthor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}