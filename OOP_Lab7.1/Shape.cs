using System;

namespace OOP_Lab7._1

{
    internal abstract class Shape
    {
        private string name;

        public Shape(string name)
        {
            this.name = name;
        }

        public virtual string Name
        {
            get { return name; }
        }

        public abstract double Area();

        public abstract double Perimeter();

    }
}
