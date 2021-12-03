using System;

namespace ClassWork_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(CompareAndCalculate(A, B));
            Console.WriteLine(OrderingNumbers(A, B, C));

        }
        static (int x, int y, int z) OrderingNumbers(int a, int b, int c)
        {
            int sumAB = a + b;
            int sumBC = b + c;
            int sumAC = a + c;
            int x, y, z;

            if (sumAB < sumBC)
            {
                if (a < b)
                {
                    x = a; y = b; z = c;
                }
                else
                {
                    x = b; y = a; z = c;
                }
            }
            else
            {
                if (b < c)
                {
                    x = b; y = c; z = a;
                }
                else
                {
                    x = c; y = b; z = a;
                }
            }
            return (x, y , z);
        }

        static string CoordinateQuarter(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return "First quarter";
            }
            else if (x < 0 && y > 0)
            {
                return "Second quarter";
            }
            else if (x < 0 && y < 0)
            {
                return "Third quarter";
            }
            else
            {
                return "Fourth quarter";
            }
        }

        static int CompareAndCalculate(int a, int b)
        {
            if (a > b)
            {
                return a + b;
            }
            else if (a == b)
            {
                return a * b;
            }
            else
            {
                return a - b;
            }
        }

        

        
    }
}
