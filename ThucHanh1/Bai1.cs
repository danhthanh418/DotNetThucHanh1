using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ThucHanh1
{
    public partial class Bai1 : Form
    {
        private DriveInfo[] allDrives = DriveInfo.GetDrives();
        public Bai1()
        {
            InitializeComponent();
            LoadDiskDrive();
            LoadViewMode();
        }

        private void LoadDataListView(string disk)
        {
            List<string> files = new List<string>();
            ListViewItem fileName = new ListViewItem();
            foreach (var fileInfor in Directory.GetFiles(cmbDiskDrive.Text))
            {
                files.Add(fileInfor.Remove(0,3));
            }

            foreach (var folders in Directory.GetDirectories(disk)) 
            {
               files.Add(folders.Remove(0, 3)); 
            }

            lvFileExplorer.Columns.Add("Name");
            lvFileExplorer.Columns.Add("Size");
            lvFileExplorer.Columns.Add("Type");
            lvFileExplorer.Columns.Add("Time");
            foreach (var file in files)
            {
                lvFileExplorer.Items.Add(file);
            }

            lvFileExplorer.LabelEdit = true;
            lvFileExplorer.AllowColumnReorder = true;
            lvFileExplorer.CheckBoxes = false;
            lvFileExplorer.FullRowSelect = true;
            lvFileExplorer.GridLines = true;
            lvFileExplorer.Sorting = SortOrder.Ascending;
        }


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
            lvFileExplorer.Clear();
            LoadDataListView(this.cmbDiskDrive.Text);
        }

        private void cmbViewMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lvFileExplorer.View = (View) cmbViewMode.SelectedIndex;
            lvFileExplorer.View = View.Details;
        }
    }
    public class StringValue
    {
        public StringValue(string s)
        {
            _value = s;
        }
        public string Value { get { return _value; } set { _value = value; } }
        string _value;
    }
}
