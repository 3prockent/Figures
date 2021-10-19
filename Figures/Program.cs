using System;

namespace Figures1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle tr = new Triangle(2, 2, 1);
                tr.changeSide("Third", 3);
                Console.WriteLine(tr.GetAngle("Alpha"));
                Console.WriteLine(tr.getPerimeter());

                EquilateralTriangle etr = new EquilateralTriangle(4);
                etr.calcArea();
                Console.WriteLine(etr.getArea());
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }
    }

    class Triangle
    {
        protected double a;
        protected double b;
        protected double c;

        public Triangle() { }

        public Triangle(double side1, double side2, double side3)
        {
            if (sideCheck(side1, side2, side3))
            {
                a = side1;
                b = side2;
                c = side3;
            }
            else
            {
                throw new Exception("The sides of the triangle are of the wrong size");
            }
        }

        public bool sideEqualityCheck(double side1, double side2, double side3)
        {
            if (side1 < (side2 + side3))
            {
                return true;
            }

            return false;
        }

        public bool sideCheck(double side1, double side2, double side3)
        {
            if ((side1 < 0) || (side2 < 0) || (side3 < 0))
            {
                throw new Exception("The side of the triangle has a negative value");
            }

            if (!(sideEqualityCheck(side1, side2, side3)
                   && sideEqualityCheck(side2, side1, side3)
                   && sideEqualityCheck(side3, side2, side1)))
            {
                throw new Exception("The sides of the triangle are of the wrong size");
            }

            return true;
        }

        public void changeSide(string nameSide, double newSide)
        {
            if (nameSide == "First")
            {
                if (sideCheck(newSide, b, c))
                {
                    a = newSide;
                }
            }
            else if (nameSide == "Second")
            {
                if (sideCheck(a, newSide, c))
                {
                    b = newSide;
                }
            }
            else if (nameSide == "Third")
            {
                if (sideCheck(a, b, newSide))
                {
                    c = newSide;
                }
            }
            else
            {
                throw new Exception("Wrongly chosen side");
            }
        }

        public double getPerimeter()
        {
            return (a + b + c);
        }

        public double GetAngle(string angle)
        {
            if (angle == "Alpha")
            {
                return (Math.Acos((b * b + c * c - a * a) / (2 * b * c)));
            }
            else if (angle == "Beta")
            {
                return (Math.Acos((a * a + c * c - b * b) / (2 * a * c)));
            }
            else if (angle == "Gamma")
            {
                return (Math.Acos((b * b + a * a - c * c) / (2 * b * a)));
            }
            else
            {
                throw new Exception("Invalid angle name");
            }

            //return 1;
        }
    }

    class EquilateralTriangle : Triangle
    {
        private double area;

        public EquilateralTriangle(double a): base (a,a,a)
        {
            
        }

        public void calcArea()
        {
            area = a * a * Math.Sqrt(3) / 4;
        }
        public double getArea()
        {
            return area;
        }
    }
}