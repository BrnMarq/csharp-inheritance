using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Equilateral: Triangle
    {
        public Equilateral(double side, string color): base(side, side, side, color) { 
        }

        public override void ShowData()
        {
            Console.WriteLine($"Soy un Triángulo Equilatero de color {Color}, Area {GetArea()}, Perímetro {GetPerimeter()}"); ;
        }
    }
}
