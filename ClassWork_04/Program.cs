using System;

namespace ClassWork_04
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static int FindMinElement(int[] mArray)
        {
            int minValue = mArray[0];

            for (int i = 1; i < mArray.Length; i++)
            {
                if (mArray[i] < minValue)
                {
                    minValue = mArray[i];
                }
            }

            return minValue;
        }

        static int FindMaxElement(int[] mArray)
        {
            int maxValue = mArray[0];

            for (int i = 1; i < mArray.Length; i++)
            {
                if (mArray[i] > maxValue)
                {
                    maxValue = mArray[i];
                }
            }

            return maxValue;
        }

        static int FindMinIndex(int[] mArray)
        {
            int minInd = 0;

            for (int i = 1; i < mArray.Length; i++)
            {
                if (mArray[minInd] > mArray[i])
                {
                    minInd = i;
                }
            }

            return minInd;
        }
       
        static int FindMaxIndex(int[] mArray)
        {
            int maxInd = 0;

            for (int i = 1; i < mArray.Length; i++)
            {
                if (mArray[maxInd] < mArray[i])
                {
                    maxInd = i;
                }
            }

            return maxInd;
        }

        static int SumOddIndex(int[] mArray)
        {
            int sum = 0;

            for (int i = 1; i < mArray.Length; i += 2)
            {
                sum += mArray[i];
            }

            return sum;
        }

        static void ReverseArray(int[] mArray)
        {
            for (int i = 0, j = mArray.Length - 1; i < mArray.Length / 2; i++, j--)
            {
                Swap(ref mArray[i], ref mArray[j]);
            }
        }

        static int CountOddElements(int[] mArray)
        {
            int count = 0;

            for (int i = 0; i < mArray.Length; i++)
            {
                if (mArray[i] % 2 == 1)
                {
                    count++;
                }
            }

            return count;
        }

        static void SwapHalfArrey(int[] mArray)
        {
            for (int i = 0, j = mArray.Length / 2 + mArray.Length % 2; i < mArray.Length / 2; i++, j++)
            {
                Swap(ref mArray[i], ref mArray[j]);
            }
        }

        static void SortArrayInsert(int [] mArray)
        {
            for(int i = 1; i < mArray.Length; i++)
            {
                int temp = mArray[i];
                int j = i;

                while (j > 0 && mArray[j - 1] > temp)
                {
                    Swap(ref mArray[j - 1], ref mArray[j]);
                    j--;
                }

                mArray[j] = temp;
            }
        } 

        static void SortingArraySelect(int[] mArray)
        {
            for (int i = 0; i < mArray.Length - 1; i++)
            {
                int minInd = i;

                for (int j = i + 1; j < mArray.Length; j++)
                {
                    if (mArray[j] > mArray[minInd])
                    {
                        minInd = j;
                    }
                    if (minInd != i)
                    {
                        Swap(ref mArray[i], ref mArray[minInd]);
                    }
                }
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
