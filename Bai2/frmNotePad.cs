using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Bai2
{
    public partial class FrmNotePad : Form
    {
        public bool _textChanged;
        public FrmNotePad()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtEditor_TextChanged(object sender, EventArgs e)
        {
            this._textChanged = true;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;

            fontDialog.MinSize = 8;
            fontDialog.MaxSize = 20;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtEditor.Font = fontDialog.Font;
                txtEditor.ForeColor = fontDialog.Color;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtEditor.Text.Length >0)
            {
                MessageBox.Show(@"Do you want to save changes to Untitled ?", @"Notepad", MessageBoxButtons.YesNoCancel);
            }
            else
            {
                FrmNotePad frmNotePad = new FrmNotePad();
                frmNotePad.Show();
            }
        }

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.Show();
        }

        private void pageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageSetupDialog pageSetupDialog  = new PageSetupDialog();
            pageSetupDialog.PageSettings = new PageSettings();
            pageSetupDialog.PrinterSettings = new PrinterSettings();
            pageSetupDialog.ShowNetwork = true;
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("OK");
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int length = txtEditor.SelectionLength;
            txtEditor.Text = txtEditor.Text.Remove(txtEditor.SelectionStart, length);
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findPreviousToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.SelectAll();
            txtEditor.Focus();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
