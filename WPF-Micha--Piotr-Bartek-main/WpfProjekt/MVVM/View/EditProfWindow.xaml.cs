﻿using System;
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
using System.Windows.Shapes;

namespace WpfProjekt
{
    /// <summary>
    /// Logika interakcji dla klasy EditProfWindow.xaml
    /// </summary>
    public partial class EditProfWindow : Window
    {
        public EditProfWindow()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Udana edycja");
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Wylogowanie użytkownika");
        }
    }
}
