using System;
using Microsoft.Win32;

namespace RegistryEdit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

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
