using Microsoft.Win32;
using System.Security.Permissions;
using System.IO;
using System;

namespace CrateManager
{
    public static class RegistryEdit
    {
        static RegistryEdit()
        {

        }

        public static void CreateSubkey()
        {
            

            string subkey = @".crate\DefaultIcon";

            RegistryKey rk = Registry.ClassesRoot.CreateSubKey(subkey);

            //C:\Users\Erik\source\repos\CrateManager\CrateManager\Images
            


            rk.Close();


        }
    }
}
