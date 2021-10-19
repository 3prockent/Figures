using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures3
{
    static class triangleClass
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }


    abstract class Triangle
    {
        protected double angle;
        protected double sideA;
        protected double sideB;
        public Triangle()
        {

        }

        public Triangle(double side1, double side2, double angle)
        {
            if ((side1 > 0) && (side2 > 0) && (angle > 0))
            {
                sideA = side1;
                sideB = side2;
                this.angle = angle*Math.PI/180;
            }
            else
            {
                throw new Exception("Wrong size of side or a negative angle value");
            }
        }

        virtual public double GetPerimeter()
        {
            double sideC;
            sideC = Math.Sqrt(sideA * sideA + sideB * sideB - 2 * sideA * sideB * Math.Cos(angle));

            return (sideA + sideB + sideC);
        }

        virtual public double GetArea()
        {
            return (0.5 * sideA * sideB * Math.Sin(angle));
        }
    }

    class RightTriangle : Triangle
    {
        public RightTriangle(double sideA, double sideB, double angle) : base(sideA, sideB, angle)
        {

        }
        override public double GetPerimeter()
        {
            if (angle == (Math.PI / 2))
            {
                return (sideA + sideB + Math.Sqrt(sideA * sideA + sideB * sideB));
            }
            else
            {
                if (sideA > sideB)
                {
                    return (sideA + sideB + Math.Sqrt(sideA * sideA - sideB * sideB));
                }
                else
                {
                    return (sideA + sideB + Math.Sqrt(sideB * sideB - sideA * sideA));
                }
            }
        }

        override public double GetArea()
        {
            if (angle == (Math.PI / 2))
            {
                return (0.5 * sideA * sideB);
            }
            else
            {
                return (0.5 * sideA * sideB * Math.Sin(angle));
            }
        }
    }

    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double sideA, double sideB, double angle) : base(sideA, sideB, angle)
        {

        }
    }
}
