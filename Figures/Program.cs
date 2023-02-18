using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5, "Azul");
            Equilateral triangle = new Equilateral(2, "Rojo");

            triangle.ShowData();
            square.ShowData();
            Console.ReadLine();
        }
    }
}
