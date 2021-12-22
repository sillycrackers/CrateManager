using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;
using System.Text.Json;
using System.Text.Json.Serialization;
using CrateManager.ViewModels;

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
        public static string SelectLoadFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Crate File|*.crate";
            openFileDialog.DefaultExt = ".crate";
            openFileDialog.Title = "Load a Crate File";
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.CheckPathExists = true;
           

            Nullable<bool> result = false;

            result = openFileDialog.ShowDialog();


            if (result == true)
            {
                return openFileDialog.FileName;
            }
            return null;
        }

        public static string SelectSaveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            Nullable<bool> result = false;

            saveFileDialog.Title = "Save a Crate File";
            saveFileDialog.Filter = "Crate File|*.crate";
            saveFileDialog.AddExtension = true;
            saveFileDialog.OverwritePrompt = true;

            

            result = saveFileDialog.ShowDialog();

            if(result == true)
            {
                return saveFileDialog.FileName;
            }
            return null;
            
        }

        public static void SaveFile(object o, string path)
        {
            string s = JsonSerializer.Serialize(o);

            File.WriteAllText(path, s);
        }

        public static T LoadFile<T>(string path)
        {
            string s = File.ReadAllText(path);

            return (T)JsonSerializer.Deserialize(s, typeof(T));
        }

    }
}
