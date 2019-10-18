using NotepadCore;
using System;
using System.Data;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Bai2
{
    public partial class FrmNotePad : Form
    {
        private FileOperation fileOperation;
        private string fileNameFullPath;
        public FrmNotePad()
        {
            InitializeComponent();
            fileOperation = new FileOperation();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog  = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog.OpenFile()) != null)
                {
                    string strFilename = openFileDialog.FileName;
                    string fileText = File.ReadAllText(strFilename);
                    txtEditor.Text = fileText;
                    //Only get filename
                    this.Text  = openFileDialog.SafeFileName;
                    fileNameFullPath = openFileDialog.FileName;
                    myStream.Close();
                }
            }
        }

        private void txtEditor_TextChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            int pos = txtEditor.SelectionStart;
            int line = txtEditor.GetLineFromCharIndex(pos) + 1;
            int col = pos - txtEditor.GetFirstCharIndexOfCurrentLine() + 1;
            toolStripStatusLabel1.Text = @"Ln " + line + @",Col " + col;
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
                DialogResult result = MessageBox.Show(@"Do you want to save changes to Untitled ?", @"Notepad", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = @"Text(*.txt)|*.txt";
                    //saveFileDialog.CheckFileExists = true;
                    saveFileDialog.DefaultExt = "txt";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Stream streamFile = saveFileDialog.OpenFile();
                        StreamWriter streamWriter = new StreamWriter(streamFile);
                        streamWriter.Write(txtEditor.Text);
                        streamWriter.Close();
                        streamFile.Close();
                        this.Text = new FileInfo(saveFileDialog.FileName).Name;
                    }
                }
                else
                {
                   txtEditor.Clear();
                   this.Text = @"Untitled - Notepad";
                }
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
                MessageBox.Show(@"OK");
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtEditor.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show(@"Do you want to save changes to Untitled ?", @"Notepad", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = @"Text(*.txt)|*.txt";
                    //saveFileDialog.CheckFileExists = true;
                    saveFileDialog.DefaultExt = "txt";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Stream streamFile = saveFileDialog.OpenFile();
                        StreamWriter streamWriter = new StreamWriter(streamFile);
                        streamWriter.Write(txtEditor.Text);
                        streamWriter.Close();
                        streamFile.Close();
                        this.Text = new FileInfo(saveFileDialog.FileName).Name;
                    }
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Stream stream = File.Open(!String.IsNullOrEmpty(fileNameFullPath) ? fileNameFullPath: Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\Untitled.txt", FileMode.OpenOrCreate,FileAccess.Write))
            {
                using(StreamWriter sw= new StreamWriter(stream))
                {
                    sw.Write(txtEditor.Text);
                    sw.Close();
                    stream.Close();
                    MessageBox.Show(txtEditor.Text);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = @"Text(*.txt)|*.txt";
            //saveFileDialog.CheckFileExists = true;
            saveFileDialog.DefaultExt = "txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream streamFile = saveFileDialog.OpenFile();
                StreamWriter streamWriter = new StreamWriter(streamFile);
                streamWriter.Write(txtEditor.Text);
                streamWriter.Close();
                streamFile.Close();
                this.Text = new FileInfo(saveFileDialog.FileName).Name;
            }
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
            if (txtEditor.Text.Length > 0)
            {
                FrmFind frmFind = new FrmFind();
                frmFind.Show();
            }
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findPreviousToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtEditor.Text.Length > 0)
            {
                FrmReplace frmReplace = new FrmReplace();
                frmReplace.Show();
            }
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
            txtEditor.Text = txtEditor.Text + DateTime.Now.ToString(CultureInfo.InvariantCulture);
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmNotePad_Load(object sender, EventArgs e)
        {
            this.Text = @"Untitled - Notepad";
            toolStripStatusLabel1.Text = @"Ln 1"  + @",Col 1";
            txtEditor.WordWrap = wordWrapToolStripMenuItem.Checked;
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void wordWrapToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            txtEditor.WordWrap = wordWrapToolStripMenuItem.Checked;
        }

        private void newWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNotePad frmNotePad = new FrmNotePad();
            frmNotePad.Show();
        }
    }
}
