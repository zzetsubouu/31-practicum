using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_practicum
{
    class Square: Figure
    {
        private double side1;
        public double Side1
        {
            get
            {
                return side1;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("значене не должно быть быть отрицательным или равно 0");
                }
                else
                {
                    side1 = value;
                }
            }
        }
        public Square(string name, double side1) : base(name)
        {
            Name = "квадрат";
            Side1 = side1;
        }
        public override double Area()
        {
            return Side1 * Side1;
        }
        public override double Perimeter()
        {
            return Side1*4;
        }
        public override string Print()
        {
            return $"стороны квадрата равны {Side1}";
        }
    }
}
