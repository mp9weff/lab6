using System;
using System.Collections.Generic;
using System.Text;

namespace lab_6
{
    public class Circle : Shape
    {
        //конструктори та властивості до класу
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle(string name, double radius) : base(name)
        {
            this.Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
