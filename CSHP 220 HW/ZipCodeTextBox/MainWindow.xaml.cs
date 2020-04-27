using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZipCodeTextBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = uxContainer;
        }

        private bool IsUSOrCanadianZipCode(string zipCode)
        {
            var _usZipRegEx = @"^\d{5}(?:[-\s]\d{4})?$";
            var _caZipRegEx = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";

            var validZipCode = true;
            if ((!Regex.Match(zipCode, _usZipRegEx).Success) && (!Regex.Match(zipCode, _caZipRegEx).Success))
            {
                validZipCode = false;
            }
            return validZipCode;
        }

        private void setButtonEnable()
        {
            if (IsUSOrCanadianZipCode(uxZip.Text) != false)
            {
                uxSubmit.IsEnabled = true;
            }
            else
            {
                uxSubmit.IsEnabled = false;
            }
        }

        private void setLabelText()
        {
            if ((IsUSOrCanadianZipCode(uxZip.Text) != true))
            {
                uxZipError.Foreground = Brushes.Red;
                uxZipError.Content = "Please enter a valid US or CAN zip code.";
            }
            else
            {
                uxZipError.Content = "";
            }
        }

        public void uxZip_TextChanged(object sender, TextChangedEventArgs e)
        {
            setButtonEnable();
            setLabelText();
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (IsUSOrCanadianZipCode(uxZip.Text) != false)
            {
                MessageBox.Show("Thanks, your zip code has been submitted.");
            }
        }
    }
}
