using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2.Functions
{
    class FileOperation
    {
        private string fileName;
        private bool isFileSaved;

        public string FileName { get => fileName; set => fileName = value; }
        public bool IsFileSaved { get => isFileSaved; set => isFileSaved = value; }
        public void InitializeNewFile()
        {
            this.FileName = "Untitled.txt";
            this.isFileSaved = true;
        }
    }
}
