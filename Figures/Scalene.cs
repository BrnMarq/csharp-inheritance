using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Scalene: Triangle
    {
        public Scalene(double sideA, double sideB, double sideC, string color): base(sideA, sideB, sideC, color) { }

        public override void ShowData()
        {
            Console.WriteLine($"Soy un Triangulo Escaleno de color {Color}, Area {GetArea()}, Perímetro {GetPerimeter()}");
        }
    }
}
