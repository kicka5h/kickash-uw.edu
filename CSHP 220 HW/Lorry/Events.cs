using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Lorry
{
    class Events : Window
    {
        private void uxFile_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void uxFileNew_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxFileNewHaiku_Click(object sender, RoutedEventArgs e)
        {

        }

        public void uxFileNewCouplet_Click(object sender, RoutedEventArgs e)
        {
            var coupletWindow = new CoupletWindow();
            var mainWindow = new MainWindow();
            Application.Current.MainWindow = coupletWindow;
            mainWindow.Close();
            coupletWindow.Show();
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
