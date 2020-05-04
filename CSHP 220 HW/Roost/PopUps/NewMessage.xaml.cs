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
    /// Interaction logic for NewMessage.xaml
    /// </summary>
    public partial class NewMessage : Window
    {
        public string strMessageName = String.Empty;
        public string strMessageBody = String.Empty;
        public bool cancelled = false;

        public NewMessage()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMessageName.Text))
            {
                strMessageName = txtMessageName.Text;
                cancelled = false;
                this.Close();
            }
            else
                MessageBox.Show("Must provide a message name in the textbox.");

            if (!String.IsNullOrEmpty(txtMessageBody.Text))
            {
                strMessageBody = txtMessageBody.Text;
                cancelled = false;
                this.Close();
            }
            else
                MessageBox.Show("Must provide a message body in the textbox.");
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            cancelled = true;
            strMessageName = String.Empty;
            strMessageBody = String.Empty;
            this.Close();
        }
    }
}
