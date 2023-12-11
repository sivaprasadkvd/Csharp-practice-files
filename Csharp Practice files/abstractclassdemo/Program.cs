using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclassdemo
{
    public abstract class Figure
    {
        public double Width, Height, Radius;
        public const float Pi = 3.14f;

        public abstract double GetArea();
    }

    public class Rectangle : Figure
    {
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double GetArea()
        {
            return Width * Height;
        }

    }
    public class Circle : Figure
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override double GetArea()
        {
            return Pi * Radius * Radius;
        }

    }

    public class Cone : Figure
    {
        public Cone(double radius, double height)
        {
            this.Radius = radius;
            this.Height = height;
        }

        public override double GetArea()
        {
            return Pi * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }

    }

    class TestFigures
    {
        public static void Main(string[] args)
        {
            Rectangle R = new Rectangle(20, 30);
            Circle C = new Circle(30);
            Cone Co = new Cone(20, 30);

            Console.WriteLine("area of rectangle is : " + R.GetArea());
            Console.WriteLine("area of circle is : " + C.GetArea());

            Console.WriteLine("area of Cone is : " + Co.GetArea());


        }
    }



}
