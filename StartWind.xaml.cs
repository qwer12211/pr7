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

namespace pr7
{
    /// <summary>
    /// Логика взаимодействия для StartWind.xaml
    /// </summary>
    public partial class StartWind : Window
    {
        public StartWind()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            EnterToIP enter = new EnterToIP();
            enter.Show();
            Close();
        }
    }
}
