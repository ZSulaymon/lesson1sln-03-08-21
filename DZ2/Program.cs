using System;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            // double a = 1.40;
            // double b = -5.50;
            // double c = 0.60;

     /*       double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double AC = Math.Round(a - c, 2);
            double BC = Math.Round(b - c, 2);

            double summ = AC + BC;*/

                 decimal a = Convert.ToDecimal(Console.ReadLine());
                 decimal b = Convert.ToDecimal(Console.ReadLine());
                 decimal c = Convert.ToDecimal(Console.ReadLine());

                 decimal AC = Math.Round(a - c,2);
                 decimal BC = Math.Round(b - c,2);
     
                 decimal summ = AC + BC;
            

            Console.WriteLine($"Длина отрезка АС = " +  AC);
            Console.WriteLine($"Длина отрезка BC = " +  BC);
            Console.WriteLine($"Сумма АC и BC = " + Math.Round(AC-BC,2));


        }
    }
}
