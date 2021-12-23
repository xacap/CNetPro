using LibraryHW;
using System;

namespace HomeWorkConsol
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            
           
            Console.WriteLine(VariablesHelper.PrintEqationYEqualsAXPlusB(x1, y1, x2, y2));
        }
    }
}
