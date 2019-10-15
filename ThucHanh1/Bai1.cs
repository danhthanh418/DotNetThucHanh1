using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace ThucHanh1
{
    public partial class Bai1 : Form
    {
        private DriveInfo[] allDrives = DriveInfo.GetDrives();
        private WebBrowser _webBrowser = new WebBrowser();
        public Bai1()
        {
            InitializeComponent();
            LoadDiskDrive();
            LoadViewMode();
        }

        //private void LoadDataListView(string disk)
        //{
        //    List<string> files = new List<string>();
        //    //Add Column Header
        //    lvFileExplorer.Columns.Add("Name", 300);
        //    lvFileExplorer.Columns.Add("Size", 150);
        //    lvFileExplorer.Columns.Add("Type", 150);
        //    lvFileExplorer.Columns.Add("Time", 150);
        //    //Get diretory
        //    foreach (var fileInfor in Directory.GetFiles(cmbDiskDrive.Text))
        //    {
        //        files.Add(fileInfor);
        //    }

        //    foreach (var folders in Directory.GetDirectories(disk)) 
        //    {
        //       files.Add(folders); 
        //    }
        //    //Add sub-item

        //    foreach (var file in files)
        //    {
        //        ListViewItem itemFile = new ListViewItem(file.Remove(0, 3));
        //        ListViewItem.ListViewSubItem subFileSize = new ListViewItem.ListViewSubItem(itemFile, "200KB");
        //        itemFile.SubItems.Add(subFileSize);
        //        ListViewItem.ListViewSubItem subFileType = new ListViewItem.ListViewSubItem(itemFile, Path.HasExtension(file) ? Path.GetExtension(file).Remove(0, 1) + " File" : "File Folder");
        //        itemFile.SubItems.Add(subFileType);
        //        ListViewItem.ListViewSubItem subFileTime = new ListViewItem.ListViewSubItem(itemFile, File.GetLastWriteTime(file).ToString(CultureInfo.InvariantCulture));
        //        itemFile.SubItems.Add(subFileTime);
        //        lvFileExplorer.Items.Add(itemFile);
        //    }

        //    lvFileExplorer.LabelEdit = true;
        //    lvFileExplorer.AllowColumnReorder = true;
        //    lvFileExplorer.CheckBoxes = false;
        //    lvFileExplorer.FullRowSelect = true;
        //    lvFileExplorer.GridLines = true;
        //    lvFileExplorer.Sorting = SortOrder.Ascending;
        //}


        private void LoadViewMode()
        {
            cmbViewMode.Items.Add(View.Details);
            cmbViewMode.Items.Add(View.LargeIcon);
            cmbViewMode.Items.Add(View.List);
            cmbViewMode.Items.Add(View.SmallIcon);
            cmbViewMode.Items.Add(View.Tile);
            cmbViewMode.SelectedIndex = 0;
            cmbViewMode.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadDiskDrive()
        {
            foreach (DriveInfo drive in allDrives)
            {
                cmbDiskDrive.Items.Add(drive.Name);
            }
            cmbDiskDrive.SelectedIndex = 0;
            cmbDiskDrive.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbDiskDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbDiskDrive.Text = this.cmbDiskDrive.SelectedItem.ToString();
            webBrowser.Url = new Uri(this.cmbDiskDrive.Text);
            //lvFileExplorer.Clear();
            //LoadDataListView(this.cmbDiskDrive.Text);
        }

        private void cmbViewMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lvFileExplorer.View = (View) cmbViewMode.SelectedIndex;
            //lvFileExplorer.View = View.Details;
        }
    }
}
