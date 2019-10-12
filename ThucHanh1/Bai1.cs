using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            LoadDataGirdView();
        }

        private void LoadDataGirdView()
        {
            List<string> files = new List<string>();
            foreach (var fileInfor in Directory.GetFiles(@"E:\\"))
            {
                files.Add(fileInfor.ToString().Remove(0,4));
            }

            foreach (var folders in Directory.GetDirectories((@"E:\\"))) 
            {
               files.Add(folders.ToString().Remove(0, 4)); 
            }
            //MessageBox.Show(cmbDiskDrive.Text);

            //dgvFileExplorer.DataSource = files;
            foreach (var file in files)
            {
                lvFileExplorer.Items.Add(file);
            }

            SetViewMode(View.List);
        }

        private void SetViewMode(object mode)
        {
            lvFileExplorer.View = (View) mode;
        }

        private void LoadViewMode()
        {
            cmbViewMode.Items.Add("Details");
            cmbViewMode.Items.Add("Large Icon");
            cmbViewMode.Items.Add("List");
            cmbViewMode.Items.Add("Small Icon");
            cmbViewMode.Items.Add("Tile");
            cmbViewMode.SelectedIndex = 0;
            cmbViewMode.DropDownStyle = ComboBoxStyle.DropDownList;
            //MessageBox.Show(View.Details.ToString());
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
        }
        //public static DataTable ToDataTable<T>( IList<T> data)
        //{
        //    PropertyDescriptorCollection props =
        //        TypeDescriptor.GetProperties(typeof(T));
        //    DataTable table = new DataTable();
        //    for (int i = 0; i < props.Count; i++)
        //    {
        //        PropertyDescriptor prop = props[i];
        //        table.Columns.Add(prop.Name, prop.PropertyType);
        //    }
        //    object[] values = new object[props.Count];
        //    foreach (T item in data)
        //    {
        //        for (int i = 0; i < values.Length; i++)
        //        {
        //            values[i] = props[i].GetValue(item);
        //        }
        //        table.Rows.Add(values);
        //    }
        //    return table;
        //}

        private void cmbViewMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetViewMode(cmbViewMode.Text);
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
