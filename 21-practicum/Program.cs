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
            // Создание объекта без параметров
            Calculate calc1 = new Calculate();
            calc1.value1 = 3.21;
            calc1.value2 = 2.21;

            // Создание объекта с явной инициализацией
            Calculate calc2 = new Calculate(8.21, 4.21);

            // Ввод значений с клавиатуры
            Console.WriteLine("введите первое значение:");
            double value1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите второе значение:");
            double value2 = Convert.ToDouble(Console.ReadLine());
            var userCalc = new Calculate(value1, value2);

            // Вывод информации о каждом объекте
            Console.WriteLine(calc1.ToString());
            Console.WriteLine($"Корень квадратный из произведения чисел (calc1): {calc1.CalculateSquareRoot()}");

            Console.WriteLine(calc2.ToString());
            Console.WriteLine($"Корень квадратный из произведения чисел (calc2): {calc2.CalculateSquareRoot()}");

            Console.WriteLine(userCalc.ToString());
            Console.WriteLine($"Корень квадратный из произведения чисел (userCalc): {userCalc.CalculateSquareRoot()}");
        }
    }
}
