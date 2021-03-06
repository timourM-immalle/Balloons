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
        List<Balloon> balloons = new List<Balloon>();

        private void MainWindowActies()
        {
            Random rnd = new Random();

            for (var i = 0; i < 100; i++)
            {
                Balloon newBalloon = new Balloon(canvas, rnd.Next(10, 500), rnd.Next(10, 500), "Wodka", rnd.Next(10, 50));
                balloons.Add(newBalloon);
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            MainWindowActies();
        }

        private void growButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Balloon b in balloons)
            {
                b.Grow();
            }
        }

        private void moveButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Balloon b in balloons)
            {
                b.Move();
            }
        }

        private void btnInit_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            balloons.Clear();

            MainWindowActies();
        }

        private void fillButton_Click(object sender, RoutedEventArgs e)
        {
            //Balloon's'.Fill();

            //foreach (Balloon b in balloons)
            //{
            //    //b.UpdateColor();
            //}

            int balloonTeller = 0;

            foreach (Balloon b in balloons)
            {
                balloonTeller++;
            }

            //for (int i = 0; i <= balloonTeller; i++)
        }
    }
}
