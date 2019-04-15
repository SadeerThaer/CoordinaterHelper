using System;
using static System.Console;

namespace CoordinaterHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Title = "Determine (x,y) place"; Write("Enter x: ");

            x = Convert.ToDouble(ReadLine()); Write("Enter y: ");
            y = Convert.ToDouble(ReadLine()); if (x > 0 && y > 0)
            {
                WriteLine("The point (" + x + "," + y + ") is on the 1st quarter!");
            }
            else if (x < 0 && y > 0)
                WriteLine("The point (" + x + "," + y + ") is on the 2nd quarter!");
            else if (x < 0 && y < 0)
                WriteLine("The point (" + x + "," + y + ") is on the 3rd quarter!");
            else if (x > 0 && y < 0)
                WriteLine("The point (" + x + "," + y + ") is on the 4th quarter!");
        }
    }
}
