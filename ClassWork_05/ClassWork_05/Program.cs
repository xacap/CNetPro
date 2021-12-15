using System;

namespace ClassWork_05
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static int GetMinElement(int[,] mArray)
        {
            int minValue = mArray[GetIndexMinValue(mArray).i, GetIndexMinValue(mArray).j];

            return minValue;
        }

        static int GetMaxElement(int[,] mArray)
        {
            int maxValue = mArray[GetIndexMaxValue(mArray).i, GetIndexMaxValue(mArray).j];

            return maxValue;
        }

        static (int i, int j) GetIndexMinValue(int[,] mArray)
        {
            int i = 0;
            int j = 0;

            for (int y = 0; y < mArray.GetLength(0); y++)
            {
                for (int x = 0; x < mArray.GetLength(1); x++)
                {
                    if (mArray[y, x] < mArray[i, j])
                    {
                        i = y;
                        j = x;
                    }
                }
            }

            return (i, j);
        }

        static (int i, int j) GetIndexMaxValue(int[,] mArray)
        {
            int i = 0;
            int j = 0;

            for (int y = 0; y < mArray.GetLength(0); y++)
            {
                for (int x = 0; x < mArray.GetLength(1); x++)
                {
                    if (mArray[y, x] > mArray[i, j])
                    {
                        i = y;
                        j = x;
                    }
                }
            }

            return (i, j);
        }

        static int CountMaxesValue(int[,] mArray)
        {
            int count = 0;
           
            for (int y = 0; y < mArray.GetLength(0); y++)
            {
                for (int x = 0; x < mArray.GetLength(1); x++)
                {
                    if (x < mArray.GetLength(1) - 1 && mArray[y, x] < mArray[y, x + 1]) 
                    {
                        continue;
                    }

                    if (y > 0 && mArray[y, x] < mArray[y - 1, x])
                    {
                        continue;
                    }

                    if (x > 0 && mArray[y, x] < mArray[y, x - 1]) 
                    {
                        continue;
                    }

                    if (y < mArray.GetLength(0) -1 && mArray[y, x] < mArray[y + 1, x])
                    {
                        continue;
                    }

                    ++count;
                }
            }

            return count;
        }

        static void DiagonalReflection(int [,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = i + 1; j < arr.GetLength(1); j++)
                {
                    Swap(ref arr[i, j], ref arr[j, i]);
                }
            }

            ArrayOutput(arr);
        }

        static void ArrayOutput (int [,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + $"  " );
                }
                Console.WriteLine();
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
