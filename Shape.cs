using System;

namespace lab_6
{
    //абстрактний клас Shape
    public abstract class Shape : IComparable<Shape>
    {
        //поле name
        private string name;
        //властивість Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       //конструктор з одним параметром
        public Shape(string name)
        {
            this.Name = name;
        }
        //абстрактні методи Area() та Perimeter(),
        //які будуть повертати площу та периметр фігури.
        public abstract double Area();

        public abstract double Perimeter();
        //сортуємо
        public int CompareTo(Shape other)
        {
            return this.Area().CompareTo(other.Area());
        }

    }
}
