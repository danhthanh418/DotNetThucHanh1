using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Bai3
{
    /// <summary>
    /// Class for icon cache and work with image lists ListView
    /// </summary>
    class IconCache
    {
        private Dictionary<string, int> iconCashe = new Dictionary<string, int>();          //Словарь для хранения индексов иконок для расширений файлов (расширение => индекс в списке изображений ListView)
        private int reserveRange = 4;                                                       //Количество зарезервированных иконок в списке


        /// <summary>
        /// Returns the index of the image in the ListView image list for file extension
        /// </summary>
        /// <param name = "extention"> File extension </param>
        /// <returns> Image index or -1 if there is no image </returns>
        public int GetIconIndexByExtention(string extention)
        {
            // to-do Return the index of the standard icon for files without extension

            List<string> extentions = iconCashe.Keys.ToList<string>();
            if (extention == null || extention.Length == 0 || extention == ".exe" || extentions.IndexOf(extention) == -1)
            {
                return -1;
            }
            return iconCashe[extention];
        }

        /// <summary>
        /// Add an icon for the file type to the image lists of the ListView element and icon cache
        /// </summary>
        /// <param name = "file"> The file for which the icon is added </param>
        /// <param name = "smallIconList"> List of small images </param>
        /// <param name = "largeIconList"> List of large images </param>
        /// <returns> Index of the added image in image lists </returns>
        public int AddIconForFile(FileInfo file, ImageList smallIconList, ImageList largeIconList)
        {
            string fileExtention = file.Extension.ToLower();

            // Get The Icon

            Icon fileIcon = Icon.ExtractAssociatedIcon(file.FullName);
            if (fileIcon == null)
            {
                return 0;
            }

            // To Lists
     
            smallIconList.Images.Add(fileIcon);
            largeIconList.Images.Add(fileIcon);

            // Cache Icons Not For .exe Files

            if (fileExtention != ".exe" && fileExtention.Length != 0)
            {
                // Add To The End
                iconCashe.Add(fileExtention, smallIconList.Images.Count - 1);
            }
           
            // Return the last index

            return smallIconList.Images.Count - 1;
        }


        /// <summary>
        /// Clear cache and list of icons
        /// </summary>
        /// <param name = "smallIconList"> List of images of small icons </param>
        /// <param name = "largeIconList"> List of images of large icons </param>
        public void ClearIconCashAndLists(ImageList smallIconList, ImageList largeIconList)
        {
            iconCashe.Clear();
            for (int i = reserveRange; i < smallIconList.Images.Count; i++)
            {
                smallIconList.Images.RemoveAt(i);
                largeIconList.Images.RemoveAt(i);
            }
        }
    }
}