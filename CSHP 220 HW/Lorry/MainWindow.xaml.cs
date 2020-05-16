using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;

namespace Lorry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var recentPoem = new LorryContext();
            recentPoem.Recent.Load();
            uxRecentPoem.DataContext = recentPoem.Recent.Local.ToObservableCollection();
        }

        private void uxFile_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void uxFileNew_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxFileNewHaiku_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxFileNewCouplet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxFileOpen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxFileExit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxEdit_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void uxEditAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxEditAddHaiku_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxEditAddCouplet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxHelp_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void uxEditAddCoupletRhyme_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxFileNewFreeForm_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxRecentLabel_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
