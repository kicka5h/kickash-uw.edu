using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Lorry
{
    public static class CollectionExtension
    {
        private static Random rng = new Random();

        public static Couplet RandomElement<Couplet>(this IList<Couplet> list)
        {
            return list[rng.Next(list.Count)];
        }

        public static Couplet RandomElement<Couplet>(this Couplet[] array)
        {
            return array[rng.Next(array.Length)];
        }
    }

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
            var haikuWindow = new HaikuWindow();
            Application.Current.MainWindow = haikuWindow;
            haikuWindow.Show();

            this.Close();
        }

        public void uxFileNewCouplet_Click(object sender, RoutedEventArgs e)
        {
            var coupletWindow = new CoupletWindow();
            Application.Current.MainWindow = coupletWindow;
            coupletWindow.Show();

            this.Close();
        }

        public void uxFileOpen_Click(object sender, RoutedEventArgs e)
        {

        }

        public void uxFileExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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

        public void uxGenerateCouplet_Click(object sender, RoutedEventArgs e)
        {
            var coupletContext = new LorryContext();
            coupletContext.Couplet.Load();

            Couplet couplet = new Couplet();
            var list = couplet.CoupletContent.ToList();
            var randomString = list.RandomElement();

            //MessageBoxButton button = MessageBoxButton.OK;
            MessageBox.Show(randomString.ToString());
        }
    }
}
