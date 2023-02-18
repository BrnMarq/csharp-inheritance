using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle: Figure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double a, double b, double c, string color): base(color) {
            _sideA = a;
            _sideB = b;
            _sideC = c;
        }

        public override double GetArea() {
            double semiperemeter = GetPerimeter() / 2;
            double firstTerm = semiperemeter - _sideA;
            double secondTerm = semiperemeter - _sideB;
            double thirdTerm = semiperemeter - _sideC;

            return Math.Sqrt(Math.Abs(semiperemeter * firstTerm * secondTerm * thirdTerm));
        }
        public override double GetPerimeter()
        {
            return _sideA + _sideB + _sideC;
        }

        public override void ShowData()
        {
            Console.WriteLine($"Soy un Triángulo de Color {Color}, Area {GetArea()}, Perimetro {GetPerimeter()}");
        }
    }
}
