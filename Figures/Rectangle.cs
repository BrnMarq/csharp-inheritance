using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Rectangle: Figure
    {
        private float _base;
        private float _height;

        public Rectangle(float @base, float height, string color): base(color)
        {
            _base = @base;
            _height = height;
            Color = color;
        }

        public override double GetArea()
        {
            return _base * _height;
        }

        public override double GetPerimeter()
        {
            return (_base * 2) + (_height * 2);
        }

        public override void ShowData()
        {
            Console.WriteLine($"Soy un Rectángulo de color {Color}, Área {GetArea()}, Perimetro {GetPerimeter()}");
        }
    }
}
