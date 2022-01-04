using System;

namespace LibraryHW
{
    public class LoopsHelper
    {
        public static int DegreeOfNumberAtoB(int a, int b)
        {
            int result = a;

            for (int i = 1; i < b; i++)
            {
                result *= a;
            }

            return result;
        }

        public static int NumbersCount(int a)
        {
            int result = 0;
            int i = 1;
            int count = 0;

            while (result < a)
            {
                i++;
                result = i * i;
                count++;
            }

            return count;
        }

        public static int MaxDivider(int a)
        {
            if (a == 0)
            {
                throw new ArgumentException("A equals to Zero!");
            }

            int maxDivider = a;

            for (int i = 2; i < maxDivider; i++)
            {
                if (a % i == 0)
                {
                    maxDivider = a / i;
                    break;
                }
                maxDivider--;
            }

            return maxDivider;
        }

        public static int SummAFromBWhichDivideBySeven(int a, int b)
        {
            int sum = 0;

            if (a > b)
            {
                Swap(ref a, ref b);
            }

            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public static int FibonacciSeries(int a)
        {
            int result = 0;
            int i = 1;
            int prewNum = 0;
            int nextNum = 1;
            int max = int.MaxValue;

            while (i < a)
            {
                result = prewNum += nextNum;
                prewNum = nextNum;
                nextNum = result;

                if (nextNum > max - nextNum)
                {
                    throw new OverflowException("Value Owerflow Int32!");
                }

                i++;
            }

            return result;
        }

        public static int MaxCommonDevider(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                throw new ArgumentException("Negative value inserted!");
            }
            while ((a != 0) && (b != 0))
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            return a + b;
        }

        public static int Task8(int a) 
        {
            int result = 0;
            int count = 0;

            while (a > count)
            {
                a /= 2;
                count += 2;
                result = count / 2;
            }

            return result;
        }

        public static int GetCountOddNumbers(int a)
        {
            int result = 0;

            while (a != 0)
            {
                if ((a % 10) % 2 != 0)
                {
                    result++;
                }
                a /= 10;
            }

            return result;
        }

        public static int MirroredSequence(int a)
        {
            int remainder;
            int reverse = 0;

            while (a != 0)
            {
                remainder = a % 10;
                reverse *= 10;
                reverse += remainder;
                a /= 10;
            }

            return reverse;
        }

        public static bool ChekingIdenticalNumbers(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                throw new ArgumentException("A and B are equal to zero!");
            }

            int remainder;

            while (a != 0)
            {
                remainder = a % 10;

                while (b != 0)
                {
                    if (b % 10 == remainder)
                    {
                        return true;
                    }

                    b /= 10;
                }

                a /= 10;
            }

            return false;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
