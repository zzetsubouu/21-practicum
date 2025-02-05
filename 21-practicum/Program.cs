using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_practicum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создание объекта без параметров
            Time time1 = new Time();
            time1.hours = 5;
            time1.minutes = 30;

            // создание объекта с явной инициализацией
            Time time2 = new Time(7, 45);

            // ввод значений с клавиатуры для объекта с тремя параметрами
            Console.WriteLine("Введите количество часов:");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество минут:");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество секунд:");
            int seconds = Convert.ToInt32(Console.ReadLine());
            var userTime = new Time(hours, minutes, seconds);

            // Вывод информации о каждом объекте
            Console.WriteLine(time1.ToString());
            Console.WriteLine($"Общее количество минут (time1): {time1.TotalMinutes()}");

            Console.WriteLine(time2.ToString());
            Console.WriteLine($"Общее количество минут (time2): {time2.TotalMinutes()}");

            Console.WriteLine(userTime.ToString());
            Console.WriteLine($"Общее количество секунд (userTime): {userTime.TotalSeconds()}");
        }
    }

}
