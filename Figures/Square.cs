using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Square: Rectangle
    {
        public Square(float side, string color): base(side, side, color)
        {
            Color = color;
        }

        public override void ShowData()
        {
            Console.WriteLine($"Soy un Cuadrado de Color {Color}, Area {GetArea()}, Perimetro {GetPerimeter()}");
        }
    }
}
