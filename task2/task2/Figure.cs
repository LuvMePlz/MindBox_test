using System;
using System.Linq;

namespace task2
{
    public abstract class Figure
    {
        protected double[] Sides;

        public Figure(double[] sides){
            if(sides is null || sides.Length == 0) throw new ArgumentOutOfRangeException("Необходимо задать стороны фигуры");
            foreach(var s in sides){
                if(s <= 0)throw new ArgumentOutOfRangeException("Стороны должны быть больше 0");
            }
            Sides = (double[])sides.Clone();
        }

        public abstract double GetArea();
    }

    public class Triangle : Figure{
        public Triangle(double a, double b, double c) : base(new double[]{a,b,c}){
        }

        public override double GetArea()
        {
            var a = Sides[0];
            var b = Sides[1];
            var c = Sides[2];
            var p = (a + b + c)/2;
            var s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return s;
        }

        public bool IsRight(){
            double[] sidesForSort = (double[])Sides.Clone();
            Array.Sort(sidesForSort);
            var c = (decimal)sidesForSort[2];
            var b = (decimal)sidesForSort[1];
            var a = (decimal)sidesForSort[0];
            return c*c == b*b + a*a;
        }
    }

    public class Circle : Figure{
        public Circle(double radius) : base(new double[]{radius}){
        }

        public override double GetArea()
        {
            var radius = Sides[0];
            var s = Math.PI * Math.Pow(radius,2);
            return s;
        }
    }
}
