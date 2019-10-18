namespace Bai2
{
    partial class FrmFind
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDown = new System.Windows.Forms.RadioButton();
            this.radUp = new System.Windows.Forms.RadioButton();
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.chkWrapAround = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Find what";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(73, 13);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(321, 20);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(401, 13);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(75, 23);
            this.btnFindNext.TabIndex = 2;
            this.btnFindNext.Text = "&Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(401, 38);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDown);
            this.groupBox1.Controls.Add(this.radUp);
            this.groupBox1.Location = new System.Drawing.Point(248, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // radDown
            // 
            this.radDown.AutoSize = true;
            this.radDown.Location = new System.Drawing.Point(80, 19);
            this.radDown.Name = "radDown";
            this.radDown.Size = new System.Drawing.Size(53, 17);
            this.radDown.TabIndex = 0;
            this.radDown.TabStop = true;
            this.radDown.Text = "&Down";
            this.radDown.UseVisualStyleBackColor = true;
            // 
            // radUp
            // 
            this.radUp.AutoSize = true;
            this.radUp.Location = new System.Drawing.Point(19, 19);
            this.radUp.Name = "radUp";
            this.radUp.Size = new System.Drawing.Size(39, 17);
            this.radUp.TabIndex = 0;
            this.radUp.TabStop = true;
            this.radUp.Text = "&Up";
            this.radUp.UseVisualStyleBackColor = true;
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.AutoSize = true;
            this.chkMatchCase.Location = new System.Drawing.Point(16, 79);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(82, 17);
            this.chkMatchCase.TabIndex = 4;
            this.chkMatchCase.Text = "Match &case";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // chkWrapAround
            // 
            this.chkWrapAround.AutoSize = true;
            this.chkWrapAround.Location = new System.Drawing.Point(16, 102);
            this.chkWrapAround.Name = "chkWrapAround";
            this.chkWrapAround.Size = new System.Drawing.Size(88, 17);
            this.chkWrapAround.TabIndex = 4;
            this.chkWrapAround.Text = "W&rap around";
            this.chkWrapAround.UseVisualStyleBackColor = true;
            // 
            // FrmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 133);
            this.Controls.Add(this.chkWrapAround);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDown;
        private System.Windows.Forms.RadioButton radUp;
        private System.Windows.Forms.CheckBox chkMatchCase;
        private System.Windows.Forms.CheckBox chkWrapAround;
    }
}