using System;

namespace ClassWork_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            //int B = Convert.ToInt32(Console.ReadLine());
            //int C = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(CompareAndCalculate(A, B));
            //Console.WriteLine(OrderingNumbers(A, B, C));
            //Console.WriteLine(QuadraticEquation(A, B, C));
            Console.WriteLine(NumberInWords(A));
        }

       
        static string NumberInWords(int number)
        {
            string numString = "";
           
            int num1 = number / 10;
            int num2 = number % 10;
            
            if (num1 == 1)
            {
                switch (num2)
                {
                    case 0:
                        numString = "Ten";
                        break;
                    case 1:
                        numString = "Eleven";
                        break;
                    case 2:
                        numString = "Twelve";
                        break;
                    case 3:
                        numString = "Thirteen";
                        break;
                    case 4:
                        numString = "Fourteen";
                        break;
                    case 5:
                        numString = "Fifteen";
                        break;
                    case 6:
                        numString = "Sixteen";
                        break;
                    case 7:
                        numString = "Seventeen";
                        break;
                    case 8:
                        numString = "Eighteen";
                        break;
                    case 9:
                        numString = "Nineteen";
                        break;
                }
                return (numString);
            }
            else 
            {
                switch (num1)
                {
                    case 2:
                        numString = "Twenty";
                        break;
                    case 3:
                        numString = "Thirty";
                        break;
                    case 4:
                        numString = "Fourty";
                        break;
                    case 5:
                        numString = "Fifty";
                        break;
                    case 6:
                        numString = "Sixty";
                        break;
                    case 7:
                        numString = "Seventy";
                        break;
                    case 8:
                        numString = "Eighty";
                        break;
                    case 9:
                        numString = "Ninety";
                        break;
                }

                switch (num2)
                {
                    case 0:
                        return (numString);
                    case 1:
                        numString = numString + " one";
                        break;
                    case 2:
                        numString = numString + " two";
                        break;
                    case 3:
                        numString = numString + " three";
                        break;
                    case 4:
                        numString = numString + " four";
                        break;
                    case 5:
                        numString = numString + " five";
                        break;
                    case 6:
                        numString = numString + " six";
                        break;
                    case 7:
                        numString = numString + " seven";
                        break;
                    case 8:
                        numString = numString + " eight";
                        break;
                    case 9:
                        numString = numString + " nine";
                        break;
                }
                return (numString);
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
