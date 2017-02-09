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

        private Brush kleur;

        Ellipse ellipse = new Ellipse();
        Random rndFill = new Random();
        TextBlock txt = new TextBlock();

        public Balloon(Canvas canvas, string naam, Brush kleur, int d, int xCo, int yCo, string tekst)
        {
            diameter = d;
            x = xCo;
            y = yCo;
            ballonTekst = tekst;

            UpdateEllipse(canvas);
        }

        public Balloon(Canvas canvas, int diameter, int xCo, int yCo, string tekst)
        {
            this.diameter = diameter;
            x = xCo;
            y = yCo;
            ballonTekst = tekst;

            UpdateEllipse(canvas);
            UpdateText(ballonTekst);
        }

        void UpdateEllipse(Canvas canvas)
        {
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Stroke = new SolidColorBrush(Colors.Red);
            ellipse.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(rndFill.Next(255)), Convert.ToByte(rndFill.Next(255)), Convert.ToByte(rndFill.Next(255))));
            canvas.Children.Add(ellipse);
        }

        void UpdateText(string tekst)
        {
            txt.Text = tekst;
            txt.Margin = ellipse.Margin;
            txt.Background = new SolidColorBrush(Colors.Blue);
        }

        void UpdateColor()
        {
            ellipse.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(rndFill.Next(255)), Convert.ToByte(rndFill.Next(255)), Convert.ToByte(rndFill.Next(255))));
        }

        public void Grow()
        {
            diameter += 10;
            ellipse.Width = diameter;
            ellipse.Height = diameter;
        }

        public void Move()
        {
            y -= 10;
            ellipse.Margin = new Thickness(x, y, 0, 0);
        }

        //public Brush Opvulkleur
        //{
        //    get { return kleur; }
        //    set { kleur = value;  UpdateColor(); }
        //}
    }
}