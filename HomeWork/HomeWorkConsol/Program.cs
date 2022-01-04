using LibraryHW;
using System;

namespace HomeWorkConsol
{
    class Program
    {
        static void Main(string[] args)
        {

            //double x1 = Convert.ToDouble(Console.ReadLine());
            //double y1 = Convert.ToDouble(Console.ReadLine());
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //double y2 = Convert.ToDouble(Console.ReadLine());
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            int[,] arr = { {  }, {  } };

            Console.WriteLine(TwoDimensionalArraysHelper.GetIndexMinValue(arr));
        }
    }
}
