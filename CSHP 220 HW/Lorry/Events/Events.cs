using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Lorry
{
    public class Events : Window
    {
        public void uxFile_Loaded(object sender, RoutedEventArgs e)
        {

        }

        public void uxFileNew_Click(object sender, RoutedEventArgs e)
        {

        }

        public void uxFileNewHaiku_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Close();

            var coupletWindow = new CoupletWindow();
            coupletWindow.Close();

            var haikuWindow = new HaikuWindow();
            Application.Current.MainWindow = haikuWindow;
            haikuWindow.Show();
        }

        public void uxFileNewCouplet_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Close();

            var haikuWindow = new HaikuWindow();
            haikuWindow.Close();

            var coupletWindow = new CoupletWindow();
            Application.Current.MainWindow = coupletWindow;
            coupletWindow.Show();
        }

        public void uxFileOpen_Click(object sender, RoutedEventArgs e)
        {

        }

        public void uxFileExit_Click(object sender, RoutedEventArgs e)
        {

        }

        public void uxEdit_Loaded(object sender, RoutedEventArgs e)
        {

        }

        public void uxEditAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        public void uxEditAddHaiku_Click(object sender, RoutedEventArgs e)
        {

        }

        public void uxEditAddCouplet_Click(object sender, RoutedEventArgs e)
        {

        }

        public void uxHelp_Loaded(object sender, RoutedEventArgs e)
        {

        }

        public void uxEditAddCoupletRhyme_Click(object sender, RoutedEventArgs e)
        {

        }

        public void uxFileNewFreeForm_Click(object sender, RoutedEventArgs e)
        {

        }

        public void uxRecentLabel_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
