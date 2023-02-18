using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public abstract class Figure
    {
        private string _color;

        public Figure(string color)
        {
            _color = color;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public string Color { get { return _color; } set { _color = value; } }

        public virtual void ShowData()
        {
            Console.WriteLine($"Soy una figura de color {_color}");
        }
    }
}
