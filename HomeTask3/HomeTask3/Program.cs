using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3
{
    // Point p = new Point();
    class Point
    {
        public string Print()
        {
            return $"x1 = {x1}, x2 = {x2}"; 
        }

        public Point(double X1, double X2)
        {
            x1 = X1;
            x2 = X2;
        }

        private double x1, x2;
    }

    // Kof p = new Kof();
    struct Kof
    {
        public double A, B, C;
    }


    class Program
    {

        static void Main(string[] args)
        {

            //Point  result = Sq(2, -4, -25);

            string s = "ололош";

            s = "маша любит кашу";

            Kof par;
            par.A = 1;
            par.B = 0;
            par.C = -4;

            Point result = Sq(par);
            Console.WriteLine(result.Print());
        }


        private static Point Sq(Kof Args)
        {
            double d = Math.Pow(Args.B, 2) - 4 * Args.A * Args.C;

            double tempX1 = 0, tempX2 = 0;

            if (d > 0)
            {
                tempX1 = (-Args.B + Math.Sqrt(d)) / (2 * Args.A);
                tempX2 = (-Args.B - Math.Sqrt(d)) / (2 * Args.A);
            }
            else if (d == 0)
            {
                tempX1 = (-Args.B) / (2 * Args.A);
                tempX2 = (-Args.B) / (2 * Args.A);
            }
            else
            {
                ///
            }

            Point result = new Point(tempX1, tempX2);

            return result;

        }

        private static Point Sq(int A, int B, int C)
        {
            double d = Math.Pow(B, 2) - 4 * A * C;

            double tempX1 = 0, tempX2 = 0;

            if (d > 0)
            {
                tempX1 = (-B + Math.Sqrt(d)) / (2 * A);
                tempX2 = (-B - Math.Sqrt(d)) / (2 * A);
            }
            else if (d == 0)
            {
                tempX1 = (-B) / (2 * A);
                tempX2 = (-B) / (2 * A);
            }
            else
            {

            }

            Point result = new Point(tempX1, tempX2);

            return result;

        }
    }
}
