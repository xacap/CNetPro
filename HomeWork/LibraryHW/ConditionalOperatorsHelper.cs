using System;

namespace LibraryHW
{
    public class ConditionalOperatorsHelper
    {
        public static string NumberInWords(int number)
        {
            if (number < 10 || number > 99)
            {
                throw new ArgumentException("Input Erorr!");
            }
            
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

        public static (double x1, double x2) QuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException("A equals to Zero!");
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                throw new ArgumentException("The equation has no solution!");
            }

            double x1 = (-b - Math.Sqrt(discriminant)) / 2 * a;
            double x2 = (-b + Math.Sqrt(discriminant)) / 2 * a;
            x1 = Math.Round(x1, 3);
            x2 = Math.Round(x2, 3);

            return (x1, x2);
        }

        public static (int a, int b, int c) IncreasingNumbers(int a, int b, int c)
        {
            int tmp = a;

            if (a > b)
            {
                Swap(ref a, ref b);
            }
            if (a > c)
            {
                Swap(ref a, ref c);
            }
            if (b > c)
            {
                Swap(ref b, ref c);
            }

            return (a, b, c);
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }

        public static int CoordinateQuarter(int x, int y)
        {
            if (x == 0 || y == 0)
            {
                throw new ArgumentException("Misses a quarter!");
            }

            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        public static int CompareAndCalculate(int a, int b)
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
