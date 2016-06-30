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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Animation view = new Animation();
            view.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BasicStyling view = new BasicStyling();
            view.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DataTemplateExample view = new DataTemplateExample();
            view.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ControlTemplateExample view = new ControlTemplateExample();
            view.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Firework view = new Firework();
            view.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Animation2 view = new Animation2();
            view.Show();
        }
    }
}
