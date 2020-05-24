using Lorry.Helpers;
using Microsoft.EntityFrameworkCore;
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
using System.Xml;

namespace Lorry
{
    /// <summary>
    /// Interaction logic for CoupletWindow.xaml
    /// </summary>
    public partial class CoupletWindow : Events
    {
        public CoupletWindow()
        {
            InitializeComponent();

            var coupletContext = new LorryContext();
            coupletContext.Couplet.Load();

            uxList.ItemsSource = coupletContext.Couplet.Local.ToObservableCollection();
        }
    }
}
