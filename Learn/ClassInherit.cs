using System;
using System.Collections.Generic;
using System.Text;

namespace Learn
{
    class ClassInherit
    {
        public void PrintValue()
        {
            Tabletop t = new Tabletop(2.0, 3.0);
            t.Display();
        }
    }
    class Rectangle
    {
        protected double length;
        protected double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}", GetArea());
        }
    }
    class Tabletop : Rectangle
    {
        private double cost;
        public Tabletop(double l, double w) : base(l, w)
        {

        }
        public double GetCost()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("成本： {0}", GetCost());
        }
    }
}
