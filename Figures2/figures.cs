using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures2
{
    class figures
    {
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }

    abstract class Figures
    {
        protected bool SidesCheck(List<double> sides)
        {
            foreach (double i in sides)
            {
                if (i < 0)
                {
                    throw new Exception("The side of the figures has a negative value");
                }
            }

            return true;
        }

        abstract public double GetArea();
        abstract public double GetPerimeter();
    }

    class Triangle : Figures
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public bool SideEqualityCheck(double side1, double side2, double side3)
        {
            if (side1 < (side2 + side3))
            {
                return true;
            }
            return false;
        }

        private bool ConditionCheck(double side1, double side2, double side3)
        {
            if ((side1 < 0) || (side2 < 0) || (side3 < 0))
            {
                throw new Exception("The side of the triangle has a negative value");
            }

            if (!(SideEqualityCheck(side1, side2, side3)
                   && SideEqualityCheck(side2, side1, side3)
                   && SideEqualityCheck(side3, side2, side1)))
            {
                throw new Exception("The sides of the triangle are of the wrong size");
            }

            return true;
        }

        public Triangle(double side1, double side2, double side3)
        {
            if (SidesCheck(new List<double>() { side1, side2, side3 }) && ConditionCheck(side1, side2, side3))
            {
                sideA = side1;
                sideB = side2;
                sideC = side3;
            }
            else
            {
                throw new Exception("The sides of the triangle are of the wrong size");
            }
        }

        override public double GetPerimeter()
        {
            return (sideA + sideB + sideC);
        }

        override public double GetArea()
        {
            double p = this.GetPerimeter() / 2;
            return (Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC)));
        }
    }

    class Circle : Figures
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new Exception("The radius of the circle has a negative value");
            }
            else
            {
                this.radius = radius;
            }
        }

        override public double GetArea()
        {
            return (2 * Math.PI * radius);
        }

        override public double GetPerimeter()
        {
            return (Math.PI * radius * radius);
        }
    }

    class Rectangle : Figures
    {
        private double sideA;
        private double sideB;

        public Rectangle(double side1, double side2)
        {
            if (SidesCheck(new List<double>() { side1, side2 }) && (side1 != side2))
            {
                sideA = side1;
                sideB = side2;
            }
            else
            {
                throw new Exception("The sides of the rectangle are of the wrong size");
            }
        }

        override public double GetArea()
        {
            return (sideA * sideB);
        }

        override public double GetPerimeter()
        {
            return (2 * (sideA + sideB));
        }
    }

    class Square : Figures
    {
        private double side;

        public Square(double side)
        {
            if (side < 0)
            {
                throw new Exception("The side of the square has a negative value");
            }
            else
            {
                this.side = side;
            }
        }

        override public double GetArea()
        {
            return (side * side);
        }

        override public double GetPerimeter()
        {
            return (4 * side);
        }
    }

    class Rhombus : Figures
    {
        private double side;
        private double angle;

        public Rhombus(double side, double angle)
        {
            if ((side < 0) || (angle < 0))
            {
                throw new Exception("The side or angle of the rhombus has a negative value");
            }
            else
            {
                this.side = side;
                this.angle = angle;
            }
        }

        override public double GetArea()
        {
            return (side * side * Math.Sin(angle));
        }

        override public double GetPerimeter()
        {
            return (4 * side);
        }
    }
}