﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab7._1
{
    internal class Square : Shape
    {
        private double side;

        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public double Side { get { return side; } }

        public override double Area()
        {
            return (Math.Pow(side, 2));
        }

        public override double Perimeter()
        {
            return (4 * side);
        }

    }
}
