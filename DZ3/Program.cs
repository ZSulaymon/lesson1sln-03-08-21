using System;

namespace DZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        Console.WriteLine("Введите x1");
                        int x1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите x2");
                        int x2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите y1");
                        int y1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите y2");
                        int y2 = Convert.ToInt32(Console.ReadLine());
                        int dist = 0;
                       // dist = Math.Pow((Math.Pow(x2, 2) - Math.Pow(x1, 2)) + (Math.Pow(y2, 2) - Math.Pow(y1, 2)));
                       dist = (int)Math.Sqrt((Math.Pow(x2, 2) - Math.Pow(x1, 2)) + (Math.Pow(y2, 2) - Math.Pow(y1, 2)));
                        Console.WriteLine(dist);*/
            double x1, x2, y1, y2, dist;
            Console.WriteLine("Введите x1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2");
            y2 = Convert.ToDouble(Console.ReadLine());
            dist = 0;
            // dist = Math.Pow((Math.Pow(x2, 2) - Math.Pow(x1, 2)) + (Math.Pow(y2, 2) - Math.Pow(y1, 2)));
           // dist = (int)Math.Sqrt((Math.Pow(x2, 2) - Math.Pow(x1, 2)) + (Math.Pow(y2, 2) - Math.Pow(y1, 2)));

            dist = (double)Math.Sqrt((Math.Pow((x2 - x1), 2) ) + (Math.Pow((y2 - y1), 2) ));
            Console.WriteLine(Math.Round(dist,2));

  
            /*double x1, x2, y1, y2, dist1,summ;
            double dist2;
            Console.WriteLine("Введите x1");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y1");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2");
            y2 = double.Parse(Console.ReadLine());
            dist1 = (double)Math.Sqrt(Math.Pow(x2, 2) - Math.Pow(x1, 2));
            dist2= (double)Math.Sqrt(Math.Pow(y2, 2) - Math.Pow(y1, 2));
            summ = dist1 + dist2;
            Console.WriteLine(Math.Sqrt(Math.Round(summ,2)));

*/
       /*     double x1, x2, y1, y2, dist1;
            double dist2;
            Console.WriteLine("Введите x1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2");
            y2 = Convert.ToDouble(Console.ReadLine());
            dist1 = Math.Sqrt(Math.Pow(x2, 2) - Math.Pow(x1, 2));
            dist2 = Math.Sqrt(Math.Pow(y2, 2) - Math.Pow(y1, 2));
            double summ = dist1 + dist2;
            Console.WriteLine(Math.Round(summ, 2));
       */
        }
    }
}
