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

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for _2ndWindow.xaml
    /// </summary>
    public partial class _2ndWindow : Window
    {
        public _2ndWindow()
        {
            InitializeComponent();

            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password="DavePwd" });
            users.Add(new Models.User { Name = "Steve", Password="StevePwd" });
            users.Add(new Models.User { Name = "Lisa", Password="LisaPwd" });

            uxList.ItemsSource = users;
        }
    }
}
