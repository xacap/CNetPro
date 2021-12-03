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
            //Console.WriteLine(QuadraticEquation(A, B, C));
            //SwitchExample();
        }

        static void SwitchExample()
        {
            Console.WriteLine("Enter 1 for task 1");
            Console.WriteLine("Enter 2 for task 2");
            Console.WriteLine("Enter 3 for task 3");

            int choise = Convert.ToInt32(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Console.WriteLine(1);
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                case 3:
                    Console.WriteLine(3);
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }

        static (double x1, double x2) QuadraticEquation(int a, int b, int c)
        {
            double discriminant = b * b - 4 * a * c;

            double x1 = (-discriminant - Math.Sqrt(discriminant)) / 2 * a;
            double x2 = (-discriminant + Math.Sqrt(discriminant)) / 2 * a;

            return (x1,x2);
        }
        static (int a, int b, int c) OrderingNumbers(int a, int b, int c)
        {
            int tmp = a;

            if (a > b)
            {
                a = b;
                b = tmp;
                tmp = a;
            }
            if (a > c)
            {
                a = c; 
                c = tmp;
                tmp = b;
            }
            if (b > c)
            {
                b = c;
                c = tmp;
            }

            return (a, b, c);
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
