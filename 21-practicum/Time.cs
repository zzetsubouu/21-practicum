using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_practicum
{
    public class Time
    {
        public int hours { get; set; }
        public int minutes { get; set; }
        public int seconds { get; set; }

        // конструктор без параметров
        public Time() { }

        // конструктор с двумя параметрами(часы и минуты)
        public Time(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        // конструктор с тремя параметрами(часы, минуты,секунды)
        public Time(int hours, int minutes, int seconds) : this(hours, minutes)
        {
            this.seconds = seconds;
        }

        // метод для вычисления общего кол-ва минут
        public int TotalMinutes()
        {
            return (hours * 60) + minutes;
        }

        // Метод для вычисления общего кол-ва секунд
        public int TotalSeconds()
        {
            return (hours * 3600) + (minutes * 60) + seconds;
        }

        // Переопределение метода ToString
        public override string ToString()
        {
            return $"Время: {hours} часов, {minutes} минут, {seconds} секунд";
        }
    }
}
