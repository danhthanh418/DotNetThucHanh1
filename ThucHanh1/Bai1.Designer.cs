namespace ThucHanh1
{
    partial class Bai1
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
            this.cmbDiskDrive = new System.Windows.Forms.ComboBox();
            this.cmbViewMode = new System.Windows.Forms.ComboBox();
            this.lvFileExplorer = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cmbDiskDrive
            // 
            this.cmbDiskDrive.FormattingEnabled = true;
            this.cmbDiskDrive.Location = new System.Drawing.Point(13, 13);
            this.cmbDiskDrive.Name = "cmbDiskDrive";
            this.cmbDiskDrive.Size = new System.Drawing.Size(121, 21);
            this.cmbDiskDrive.TabIndex = 0;
            this.cmbDiskDrive.SelectedIndexChanged += new System.EventHandler(this.cmbDiskDrive_SelectedIndexChanged);
            // 
            // cmbViewMode
            // 
            this.cmbViewMode.FormattingEnabled = true;
            this.cmbViewMode.Location = new System.Drawing.Point(179, 13);
            this.cmbViewMode.Name = "cmbViewMode";
            this.cmbViewMode.Size = new System.Drawing.Size(121, 21);
            this.cmbViewMode.TabIndex = 0;
            this.cmbViewMode.SelectedIndexChanged += new System.EventHandler(this.cmbViewMode_SelectedIndexChanged);
            // 
            // lvFileExplorer
            // 
            this.lvFileExplorer.HideSelection = false;
            this.lvFileExplorer.Location = new System.Drawing.Point(13, 49);
            this.lvFileExplorer.Name = "lvFileExplorer";
            this.lvFileExplorer.Size = new System.Drawing.Size(775, 448);
            this.lvFileExplorer.TabIndex = 1;
            this.lvFileExplorer.UseCompatibleStateImageBehavior = false;
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.lvFileExplorer);
            this.Controls.Add(this.cmbViewMode);
            this.Controls.Add(this.cmbDiskDrive);
            this.Name = "Bai1";
            this.Text = "DemoListView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDiskDrive;
        private System.Windows.Forms.ComboBox cmbViewMode;
        private System.Windows.Forms.ListView lvFileExplorer;
    }
}

