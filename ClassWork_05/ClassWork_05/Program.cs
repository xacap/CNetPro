using System;

namespace ClassWork_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4] 
            {
                {97, 56, 78, 18},
                {45, 6,  53, 66},
                {8,  29, 71, 33},
                {22, 77, 88, 44 }
            };

            //DiagonalReflection(array);
            //ArrayOutput(array);
            //Console.WriteLine(CountMaxesValue(array));
        }

        static int FindMinElement(int[,] mArray)
        {
            int minValue = mArray[0, 0];

            for (int y = 0; y < mArray.GetLength(0); y++)
            {
                for (int x = 0; x < mArray.GetLength(1); x++)
                {
                    if (mArray[y, x] < minValue)
                    {
                        minValue = mArray[y,x];
                    }
                }
            }

            return minValue;
        }

        static int FindMaxElement(int[,] mArray)
        {
            int maxValue = mArray[0, 0];

            for (int y = 0; y < mArray.GetLength(0); y++)
            {
                for (int x = 0; x < mArray.GetLength(1); x++)
                {
                    if(mArray[y, x] > maxValue)
                    {
                        maxValue = mArray[y, x];
                    }
                }
            }

            return maxValue;
        }

        static (int y, int x) FindIndexMinValue(int[,] mArray)
        {
            int row = 0;
            int column = 0;

            for (int y = 0; y < mArray.GetLength(0); y++)
            {
                for (int x = 0; x < mArray.GetLength(1); x++)
                {
                    if (mArray[y, x] < mArray[row, column])
                    {
                        row = y;
                        column = x;
                    }
                }
            }

            return (row, column);
        }

        static (int y, int x) FindIndexMaxValue(int[,] mArray)
        {
            int row = 0;
            int collumn = 0;

            for (int y = 0; y < mArray.GetLength(0); y++)
            {
                for (int x = 0; x < mArray.GetLength(1); x++)
                {
                    if (mArray[y, x] > mArray[row, collumn])
                    {
                        row = y;
                        collumn = x;
                    }
                }
            }

            return (row, collumn);
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

        static void Swap (ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
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
    }
}
