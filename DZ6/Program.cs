using System;

namespace DZ6
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("Введите номер дня=");
            day = Convert.ToInt32(Console.ReadLine());
            while (day > 7)
                day -= 7;
            /*1-Понедельник,2-Вторник и т.д*/
            Console.WriteLine("День недели=" + day);
            Console.ReadKey();
        }
    }
}
