using System;

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 16.80;
            double b = 12.40;

            double c = a * b;
            double result = Math.Sqrt(c);
            Console.WriteLine(Math.Round(result, 2));
        }
    }
}
