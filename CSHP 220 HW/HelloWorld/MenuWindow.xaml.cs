﻿using System;
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
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void OnNew_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New command");
        }
        private void OnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OnNew_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = IsFileNewActive;
        }

        private bool IsFileNewActive
        {
            get
            {
                return false;
            }
        }

        private void uxFile_Loaded(object sender, RoutedEventArgs e)
        {
            uxFileNew.IsEnabled = IsFileNewActive;
        }
    }
}
