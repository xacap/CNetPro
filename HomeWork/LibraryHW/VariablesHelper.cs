using System;


namespace LibraryHW
{
    public class VariablesHelper
    {
        public static double CalculateEqantion(double a, double b)
        {
            if (a == b)
            {
                throw new ArgumentException("A equal to B!");
            }

            return (5 * a) + (b * b) / (b - a);

        }

        public static string  SwichString(string A, string B)
        {
            string tmp = A;
            A = B;
            B = tmp;

            return A + B;
        }

        public static (int i, int j) DivideAndGetRemainder(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("B equal to zero!");
            }

            int divisionResult = a / b;
            int remainder = a % b;

            return (divisionResult, remainder);
        }

        public static double LinearEquation(double a, double b, double c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                throw new ArgumentException("Input Error!");
            }

            double X  = (c - b) / a;
            return X;
        }

        public static (double A, double B) PrintEqationYEqualsAXPlusB(
            double x1, double y1, double x2, double y2)
        {
            if (x1 == x2)
            {
                throw new DivideByZeroException("x1 equal to x2!");
            }

            double A = Math.Round((y2 - y1) / (x2 - x1), 2);
            double B = Math.Round ((y1 - x1 * A), 2);
    
            Console.WriteLine("Y =" + A + "X + " + B);

            return (A, B);
        }
    }
}
