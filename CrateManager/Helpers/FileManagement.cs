using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CrateManager
{
    public static class FileManagement
    {

        static FileManagement()
        {

        }

        /// <summary>
        /// Select File method will open dialog to select file
        /// It will return string of file path if succesful or Null if failed
        /// </summary>
        /// <returns></returns>
        public static string SelectFile()
        {
            OpenFileDialog _openFileDialog = new OpenFileDialog();
            string fileName;

            Nullable<bool> result = false;

            result = _openFileDialog.ShowDialog();

            if (result == true)
            {
                fileName = _openFileDialog.FileName;
                return fileName;
            }
            return null;
        }

        public static void SaveFile(object o, string path)
        {
            string s = JsonSerializer.Serialize(o);

            File.WriteAllText(path, s);
        }

    }
}
