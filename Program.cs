using System;

namespace Lab1._4_Homework_Kuzmina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Напишите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Напишите ваш город прожтвания: ");
            string city = Console.ReadLine();
            Console.Write("Напишите ваше любимое число: ");
            int luv = Convert.ToInt32(Console.ReadLine());
            Console.Write("Напишите температуру в градусах Цельсия за окном: ");
            int tem = Convert.ToInt32(Console.ReadLine());

            int kv = (int)Math.Pow(luv, 2);
            int age2 = age + 1;
            double f = (tem * (9.0 / 5.0)) + 32;

            Console.WriteLine("");
            Console.WriteLine("=== ПЕРСОНАЛЬНЫЙ ПРОФИЛЬ ===");
            Console.WriteLine("");
            Console.WriteLine("Привет, {0}!", name);
            Console.WriteLine("Тебе {0} лет.", age);
            Console.WriteLine("В следующем году тебе будет {0}.", age2);
            Console.WriteLine("");
            Console.WriteLine("Ты живешь в городе {0}.", city);
            Console.WriteLine("Твой любимое число: {0} (в квадрате: {1})", luv, kv);
            Console.WriteLine("");
            Console.WriteLine("Температура за окном:");
            Console.WriteLine("- В Цельсиях: {0}°C", tem);
            Console.WriteLine("- В Фаренгейтах: {0}°F", f);
            Console.WriteLine("");
            Console.WriteLine("=== КОНЕЦ ПРОФИЛЯ ===");
            Console.ReadLine();
            

        }
    }
}
