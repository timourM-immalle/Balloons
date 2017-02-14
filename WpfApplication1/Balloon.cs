using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace WpfApplication1
{
    // ENCAPSULATIE

    class Balloon
    {
        private int x = 10;
        private int y = 100;
        private int diameter = 10;

        private string ballonTekst;

        public Brush kleur;
        //Canvas canvas;

        Ellipse ellipse = new Ellipse();
        Random rndFill = new Random();
        TextBlock txt = new TextBlock();

        public Balloon(Canvas canvas, int xCo, int yCo, string tekst, string naam, Brush kleur, int d = 10)
        {
            diameter = d;
            x = xCo;
            y = yCo;
            ballonTekst = tekst;

            UpdateEllipse(canvas);
        }

        public Balloon(Canvas canvas, int xCo, int yCo, string tekst, int diameter = 10)
        {
            this.diameter = diameter;
            x = xCo;
            y = yCo;
            //ballonTekst = tekst;

            UpdateEllipse(canvas);
            //UpdateText(tekst);
        }

        private void UpdateEllipse(Canvas canvas)
        {
            ellipse.Width = diameter;
            ellipse.Height = ellipse.Width;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Stroke = new SolidColorBrush(Colors.Red);
            ellipse.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(rndFill.Next(255)), Convert.ToByte(rndFill.Next(255)), Convert.ToByte(rndFill.Next(255))));
            canvas.Children.Add(ellipse);
        }

        private void UpdateText()
        {
            txt.Text = ballonTekst;
            txt.Margin = ellipse.Margin;
        }

        public void UpdateColor()
        {
            ellipse.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(rndFill.Next(255)), Convert.ToByte(rndFill.Next(255)), Convert.ToByte(rndFill.Next(255))));
        }

        public void Grow()
        {
            diameter += 10;
            ellipse.Width = diameter;
            ellipse.Height = ellipse.Width;
        }

        public void Move()
        {
            y -= 10;
            ellipse.Margin = new Thickness(x, y, 0, 0);
        }

        public Brush Opvulkleur
        {
            set
            {
                UpdateColor();
            }
        }
    }
}