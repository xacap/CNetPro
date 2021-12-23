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

        public static int Task3(int a)
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

        public static int Task4(int a)
        {
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

        public static int Task6(int a)
        {
            int result = 0;
            int i = 1;
            int prewNum = 0;
            int nextNum = 1;

            while (i < a)
            {
                result = prewNum += nextNum;
                prewNum = nextNum;
                nextNum = result;

                i++;
            }

            return result;
        }

        public static int Task7(int a, int b)
        {

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

        public static int Task9(int a)
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

        public static int Task10(int a)
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

        public static bool Task12(int a, int b)
        {
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
