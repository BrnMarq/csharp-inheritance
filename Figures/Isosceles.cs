using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Isosceles: Triangle
    {
        public Isosceles(double side, double @base, string color): base(side, side, @base, color) { }

        public override void ShowData()
        {
            Console.WriteLine($"Soy un Triángulo Isosceles de color {Color}, Area {GetArea()}, Perímetro {GetPerimeter()}");
        }
    }
}
