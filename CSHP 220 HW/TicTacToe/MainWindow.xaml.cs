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
        string player;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void disableButtons()
        {
            foreach (DependencyObject cell in uxGrid.Children)
            {
                ((Button)cell).IsEnabled = false;
            }
        }

        private void enableButtons()
        {
            foreach (DependencyObject cell in uxGrid.Children)
            {
                ((Button)cell).IsEnabled = true;
            }
        }

        private void uxNewGame_Click(object sender, RoutedEventArgs e)
        {
            clicks = 0;

            foreach (DependencyObject cell in uxGrid.Children)
            {
                ((Button)cell).Content = String.Empty;
            }

            enableButtons();

            MessageBox.Show("Ready for a new game! Player X goes first.");
        }

        private void uxExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            clicks++;

            Button button = e.Source as Button;

            var ParseTag = button.Tag.ToString().Split(",");

            int GridRow = int.Parse(ParseTag[0]);
            int GridColumn = int.Parse(ParseTag[1]);

            if (clicks % 2 == 0)
            {
                button.Content = "O";
                player = "Player O";

                MessageBox.Show("Next turn");
            }
            else
            {
                button.Content = "X";
                player = "Player X";

                MessageBox.Show("Next turn");
            }

            var checkRow = from b in uxGrid.Children.OfType<Button>()
                           where b.Content != null &&
                           b.Content.ToString() == button.Content.ToString() &&
                           b.Tag.ToString().Split(",")[0] == button.Tag.ToString().Split(",")[0]
                           select b;

            var rowWinner = checkRow.Count() == 3;

            var checkColumn = from b in uxGrid.Children.OfType<Button>()
                              where b.Content != null &&
                              b.Content.ToString() == button.Content.ToString() &&
                              b.Tag.ToString().Split(",")[1] == button.Tag.ToString().Split(",")[1]
                              select b;

            var columnWinner = checkColumn.Count() == 3;

            if (rowWinner || columnWinner)
            {
                disableButtons();
                MessageBox.Show($"Winner winner, chicken dinner! {player} has won!");
            }
        }
    }
}
