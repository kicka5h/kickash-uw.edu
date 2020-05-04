using Microsoft.EntityFrameworkCore;
using Roost.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

namespace Roost
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            var message = new MessagesContext();
            message.Message.Load();
            var messages = message.Message.Local.ToObservableCollection();

            var contact = new ContactsContext();
            contact.Contact.Load();
            var contacts = contact.Contact.Local.ToObservableCollection();
        }

        #region New button clicks
        private void uxNew_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void uxNewCollection_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxNewMessage_Click(object sender, RoutedEventArgs e)
        {
            NewMessage popup = new NewMessage();  // this is the class of your other page

            //ShowDialog means you can't focus the parent window, only the popup
            popup.ShowDialog(); //execution will block here in this method until the popup closes

            if (popup.cancelled == true)
                return;
            else
            {
                string result = popup.strMessageName;
                //UserNameTextBlock.Text = result;  // should show what was input on the other page
            }        
        }

        private void uxNewSchedule_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region Open button clicks
        private void uxOpen_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void uxOpenMessages_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxOpenCollections_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxOpenSchedules_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region Help button clicks
        private void uxHelp_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void uxHelpMessages_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxHelpCollections_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxHelpSchedules_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region Edit button clicks
        private void uxEdit_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void uxEditMessage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxEditCollection_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxEditSchedule_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}
