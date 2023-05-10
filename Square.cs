using System;
using System.Collections.Generic;
using System.Text;

namespace lab_6
{
     public class Square : Shape
     {
        //конструктори та властивості до класу
        public double side;

        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        public Square(string name, double side) : base(name)
        {
            this.Side = side;
        }

        public override double Area()
        {
            return Math.Pow(Side, 2);
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }
     }
}
