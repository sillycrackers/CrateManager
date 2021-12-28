using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CrateManager.ViewModels;
using CrateManager.Models;
using System.Collections.ObjectModel;

namespace CrateManager
{
    public static class GetRandom
    {
        private static CratesViewModel _cratesVM;

        static GetRandom()
        {
           
        }

        public static void GenerateMockCrates(CratesViewModel cratesViewModel)
        {
        
            _cratesVM = cratesViewModel;

            string user = Environment.UserName;
            string path = String.Format("C:\\Users\\{0}\\source\\repos\\CrateManager\\CrateManager\\Helpers\\MockData\\MOCK_DATA.csv",user);

            string[] buffer = File.ReadAllLines(path);
            List<string[]> itemsNoComma = new List<string[]>();
            int numCrates = 20;
           
            //Convert to no commas
            for (int x = 1, i = buffer.Length; x < i; x++)
            {
                itemsNoComma.Add(buffer[x].Split(','));
            }

            int totalItems = buffer.Length - 1;
            int numItemsPerCrate = totalItems / numCrates;
            int j = 0;
            //Loop through all crates
            for(int x = 0; x < numCrates; x++)
            {
                //Add a crate
                _cratesVM.Crates.Add(new Crate($"A{x}", "Electrical", "Stuff, Stuff, Stuff", x));

                //Add all items per crate
                for(int i = 0; i < numItemsPerCrate; i++)
                {
                    _cratesVM.Crates[x].Items.Add(new CrateItem(itemsNoComma[j][0], itemsNoComma[j][1], Convert.ToInt32(itemsNoComma[j][2]), itemsNoComma[j][3]));
                    j++;
                }

                _cratesVM.CrateViewModels.Add(new CrateViewModel(_cratesVM.Crates[x]));
            }

           
        }

    }
}
