using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryHW
{
    public class OneDimensionalArraysHelper
    {
        public static int GetMinElement(int[] mArray)
        {
            if (mArray == null || mArray.Length == 0)
            {
                throw new ArgumentException("Missing array or array length equal to zero!");
            }

            int minValue = mArray[0];

            for (int i = 0; i < mArray.Length; i++)
            {
                if (mArray[i] < minValue)
                {
                    minValue = mArray[i];
                }
            }

            return minValue;
        }

        public static int GetMaxElement(int[] mArray)
        {
            if (mArray == null || mArray.Length == 0)
            {
                throw new ArgumentException("Missing array or array length equal to zero!");
            }

            int maxValue = mArray[0];

            for (int i = 0; i < mArray.Length; i++)
            {
                if (mArray[i] > maxValue)
                {
                    maxValue = mArray[i];
                }
            }

            return maxValue;
        }

        public static int GetIndexMinElement(int[] mArray)
        {
            if (mArray == null || mArray.Length == 0)
            {
                throw new ArgumentException("Missing array or array length equal to zero!");
            }

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

        public static int GetIndexMaxElement(int[] mArray)
        {
            if (mArray == null || mArray.Length == 0)
            {
                throw new ArgumentException("Missing array or array length equal to zero!");
            }

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

        public static int SumElementsWithOddIndex(int[] mArray)
        {
            if (mArray == null)
            {
                throw new ArgumentException("Missing array!");
            }

            int sum = 0;

            for (int i = 1; i < mArray.Length; i += 2)
            {
                sum += mArray[i];
            }

            return sum;
        }

        public static void ReverseArray(int[] mArray)
        {
            if (mArray == null)
            {
                throw new ArgumentException("Missing array!");
            }

            for (int i = 0, j = mArray.Length - 1; i < mArray.Length / 2; i++, j--)
            {
                Swap(ref mArray[i], ref mArray[j]);
            }
        }

        public static int CountOddElements(int[] mArray)
        {
            if (mArray == null)
            {
                throw new ArgumentException("Missing array!");
            }

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

        public static void SwapHalfArrey(int[] mArray)
        {
            if (mArray == null)
            {
                throw new ArgumentNullException("Array is null!");
            }

            for (int i = 0, j = mArray.Length / 2 + mArray.Length % 2; i < mArray.Length / 2; i++, j++)
            {
                Swap(ref mArray[i], ref mArray[j]);
            }
        }

        public static void SortArrayInsert(int[] mArray)
        {
            if (mArray == null)
            {
                throw new ArgumentNullException("Array is null!");
            }

            for (int i = 1; i < mArray.Length; i++)
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

        public static void SortingArraySelect(int[] mArray)
        {
            if (mArray == null)
            {
                throw new ArgumentNullException("Array is null!");
            }

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
