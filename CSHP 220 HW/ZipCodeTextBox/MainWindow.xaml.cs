using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using ZipCodeTextBox.Models;

namespace ZipCodeTextBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Models.ZipCode zipcode = new Models.ZipCode();

        public MainWindow()
        {
            InitializeComponent();

            uxContainer.DataContext = zipcode;
        }

        private void setButtonEnable()
        {
            if ((uxUSZip.Text == String.Empty) && (uxCANZip.Text == String.Empty)) 
            {
                uxButton.IsEnabled = false;
            }
            else 
            {
                uxButton.IsEnabled = true;
            }
        }

        private void uxUSZip_TextChanged(object sender, TextChangedEventArgs e)
        {
            setButtonEnable();
        }

        private void uxCANZip_TextChanged(object sender, TextChangedEventArgs e)
        {
            setButtonEnable();
        }

        private void uxButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
