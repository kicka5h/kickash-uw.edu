using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace Lorry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Events
    {
        public MainWindow()
        {
            InitializeComponent();

            var recentPoem = new LorryContext();
            recentPoem.Recent.Load();
            uxRecentPoem.DataContext = recentPoem.Recent.Local.ToObservableCollection();
        }
    }
}