﻿using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using CrateManager.Models;
using System.Linq;
using System;

namespace CrateManager.ViewModels
{
    public class CratesViewModel : BaseViewModel
    {
        public ICommand GenerateCrateCommand { get; set; }

        public ObservableCollection<Crate> Crates { get; set; }

        public Crate SelectedCrate { get; set; }

        public ObservableCollection<CrateViewModel> CrateViewModels { get; set; }
        
        public CrateViewModel SelectedCrateViewModel { get; set; }



        public int TestVal { get; set; } = 5;


        public CratesViewModel()
        {
            GenerateCrateCommand = new GenerateCrateCommand(this);
            Crates = new ObservableCollection<Crate>();
            SelectedCrateViewModel = new CrateViewModel();
            CrateViewModels = new ObservableCollection<CrateViewModel>();
 
        }

        public void ExecuteGenerateCrate()
        {
            Crate crate = new Crate(string.Format("Crate {0}", Crates.Count + 1), "Miscellaneous", Crates.Count + 1);
            Crates.Add(crate);
            CrateViewModels.Add(new CrateViewModel(Crates[Crates.Count-1]));
        }

        public void UpdateSelectedCrateViewModel(int id)
        {
            SelectedCrateViewModel = CrateViewModels[id-1];
        }
    }
}
