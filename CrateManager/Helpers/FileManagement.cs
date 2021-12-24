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
        public enum FileType
        {
            Crate,
            Csv
        }

        static FileManagement()
        {

        }

        /// <summary>
        /// Select File method will open dialog to select file
        /// It will return string of file path if succesful or Null if failed
        /// </summary>
        /// <returns></returns>
        public static string SelectLoadFile(FileType fileType)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            switch (fileType)
            {
                case FileType.Crate:
                    openFileDialog.Filter = "Crate File|*.crate";
                    openFileDialog.DefaultExt = ".crate";
                    openFileDialog.Title = "Load a Crate File";
                    break;
                case FileType.Csv:
                    openFileDialog.Filter = "CSV File|*.csv";
                    openFileDialog.DefaultExt = ".csv";
                    openFileDialog.Title = "Load a CSV File";
                    break;
            }
            
           

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

        public static string SelectSaveFile(FileType fileType)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();


            switch (fileType)
            {
                case FileType.Crate:
                    saveFileDialog.Title = "Save a Crate File";
                    saveFileDialog.Filter = "Crate File|*.crate";
                    break;
                case FileType.Csv:
                    saveFileDialog.Title = "Save a CSV File";
                    saveFileDialog.Filter = "CSV File|*.csv";
                    break;
            }


            Nullable<bool> result = false;


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

        public static T LoadFile<T>(string path) where T : new()
        {
            string s = File.ReadAllText(path);

            return (T)JsonSerializer.Deserialize(s, typeof(T));
        }

        public static void ExportCSV(string output)
        {
            string path = SelectSaveFile(FileType.Csv);

            if (!string.IsNullOrWhiteSpace(path))
            {
                File.WriteAllText(path, output);
            }
        }
    }
}
