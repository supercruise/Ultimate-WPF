using System;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Firework.xaml
    /// </summary>
    public partial class Firework : Window
    {
        private List<Brush> Colors;

        public Firework()
        {
            InitializeComponent();
            this.DataContext = this;

            // Initialize color brushes
            Colors = new List<Brush>();
            Colors.Add(Brushes.Red);
            Colors.Add(Brushes.Violet);
            Colors.Add(Brushes.Yellow);
            Colors.Add(Brushes.Chartreuse);
            Colors.Add(Brushes.Blue);
        }
        

        private void container_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Random generator
            Random rndm = new Random();

            // Create a new instance of the explosion user control
            Explosion boomboom = new Explosion();
            
            // Scale
            ScaleTransform scale = new ScaleTransform();
            scale.ScaleX = scale.ScaleY = rndm.NextDouble() * 1.5;
            boomboom.RenderTransform = scale;

            // Color
            int i = rndm.Next(0, 5);
            if (i < 5)
                boomboom.Color = Colors[i];

            // Add this explosion to the grid and set its position            
            Point pt = e.GetPosition(container);
            Canvas.SetLeft(boomboom, pt.X);
            Canvas.SetTop(boomboom, pt.Y);

            this.container.Children.Add(boomboom);

        }
    }
}
