using System;

namespace DZ4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите двухзначное число: ");

            string input = Console.ReadLine();

            int number = 0;

            /*if (input.Length != 2 || !int.TryParse(input, out number))

            {
                Console.WriteLine("Неверный ввод. Экстренное завершение!");
                return;
            }*/

            Console.WriteLine("Число, полученное при перестановке первой и второй цифры: {1}{0}", input[0], input[1]);

        }
    
    }
}
