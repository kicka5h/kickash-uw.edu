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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int clicks;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void uxNewGame_Click(object sender, RoutedEventArgs e)
        {
            clicks = 0;
            
            foreach (DependencyObject cell in uxGrid.Children)
            {
                ((Button)cell).Content = String.Empty;
            }
        }

        private void uxExit_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            clicks++;

            Button button = e.Source as Button;

            var ParseTag = button.Tag.ToString().Split(",");

            int GridRow = int.Parse(ParseTag[0]);
            int GridColumn = int.Parse(ParseTag[1]);

            if (clicks%2 == 0)
            {
                button.Content = "O";    
            }
            else {button.Content = "X";}
        }

    }
}
