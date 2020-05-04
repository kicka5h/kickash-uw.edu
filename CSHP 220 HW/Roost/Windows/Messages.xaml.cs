using Microsoft.EntityFrameworkCore;
using Roost.Models;
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

namespace Roost
{
    /// <summary>
    /// Interaction logic for Messages.xaml
    /// </summary>
    public partial class Messages : Window
    {
        public Messages()
        {
            InitializeComponent();

            var message = new MessagesContext();
            message.Message.Load();
            var messages = message.Message.Local.ToObservableCollection();
        }

        private void Add_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
