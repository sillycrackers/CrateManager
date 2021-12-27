using CrateManager.Models;
using CrateManager.ViewModels;
using CrateManager.Views;
using System.ComponentModel;
using System.Windows;
using System.Threading;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System;

namespace CrateManager
{

   

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            //Blank view
            DataContext = new MainViewModel();

            //Create new Menu object passing in this window. When loading file it will assign it to the window's Datacontext
            MainMenu.DataContext = new MainMenuViewModel(this);

            

        }

        //Update datacontext of Export Menu if it changes
        private void Window_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            ExportMenu.DataContext = new ExportMenuViewModel(this);
        }

        private void CrateImageMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            double crateImageCenterX = CrateImage.Width / 2.0;
            double crateImageCenterY = CrateImage.Height / 2.0;

            RotateTransform rotateTransform1 = new RotateTransform(0, crateImageCenterX, crateImageCenterY);
            TranslateTransform translateTransform1 = new TranslateTransform(0, 0);
            TransformGroup transformGroup1 = new TransformGroup();

            transformGroup1.Children.Add(rotateTransform1);
            transformGroup1.Children.Add(translateTransform1);

            CrateImage.RenderTransform = transformGroup1;

            DoubleAnimation rotateAnimation1 = new DoubleAnimation(-360, TimeSpan.FromSeconds(2));
            DoubleAnimation translateAnimation1 = new DoubleAnimation(-150, TimeSpan.FromSeconds(2));

            rotateAnimation1.AutoReverse = true;
            translateAnimation1.AutoReverse = true;

            rotateAnimation1.DecelerationRatio = 0.15;

            translateAnimation1.DecelerationRatio = 0.2;

            rotateTransform1.BeginAnimation(RotateTransform.AngleProperty, rotateAnimation1, HandoffBehavior.SnapshotAndReplace);
            translateTransform1.BeginAnimation(TranslateTransform.XProperty, translateAnimation1, HandoffBehavior.SnapshotAndReplace);
        }
    }
}
