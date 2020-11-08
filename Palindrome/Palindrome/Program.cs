using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            int newNum = 0;
            int oldNum = num;

            // Пока копия старого числа не равна 0, переносим его в новую переменную, переворачивая.
            while (oldNum > 0)
            {
                newNum = newNum * 10 + oldNum % 10;
                oldNum = oldNum / 10;
            }

            // Если новая переменная равна старой, то палиндром.
            if (num == newNum)
                Console.WriteLine("Палиндром");
            else
                Console.WriteLine("Не палиндром");

            Console.ReadKey();
        }
    }
}
