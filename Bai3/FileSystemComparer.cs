using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bai3
{
    class FileSystemComparer : IComparer
    {
        public enum SORTORDER { DESC, ASC };

        public int columnIndex = 0; // Column by which the sorting is performed
        public SORTORDER sortOrder = SORTORDER.ASC; //Sorting direction

        public int Compare(object x, object y)
        {

            // Get links to file system objects

            FileSystemInfo firstFile = ((ListViewItem)x).Tag as FileSystemInfo;
            FileSystemInfo secondFile = ((ListViewItem)y).Tag as FileSystemInfo;

            // Check
            if (firstFile == null || secondFile == null)
            {
                return 0;
            }
            // Folders have more files (located above)

            if (firstFile is DirectoryInfo && secondFile is FileInfo)
            {
                return -1;
            }
            if (firstFile is FileInfo && secondFile is DirectoryInfo)
            {
                return 1;
            }

            //По какому параметру сортируем сортируем

            int result = 0;
            switch (columnIndex)
            {
                //по имени

                case 0:
                    result = firstFile.Name.CompareTo(secondFile.Name);
                    break;

                //по размеру

                case 1:
                    if (firstFile is FileInfo && secondFile is FileInfo)
                    {
                        result = ((FileInfo)firstFile).Length.CompareTo(((FileInfo)secondFile).Length);
                    }
                    else
                    {
                        return 0;
                    }
                    break;

                //время создания

                case 2:
                    result = firstFile.CreationTime.CompareTo(secondFile.CreationTime);
                    break;

                //время изменения

                case 3:
                    result = firstFile.LastWriteTime.CompareTo(secondFile.LastWriteTime);
                    break;

                //Неведомая херня :)

                default:
                    return 0;
            }

            //Обработка порядка сортировки

            if (sortOrder == SORTORDER.ASC)
            {
                return result;
            }
            else
            {
                return (-1) * result;
            }
        }
    }
}