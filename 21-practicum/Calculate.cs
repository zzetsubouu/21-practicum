using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_practicum
{
    public class Calculate
    {
        public double value1 { get; set; }
        public double value2 { get; set; }
        public Calculate()
        {

        }
        public Calculate(double value1)
        {
            this.value1 = value1;
        }
        public Calculate(double value1, double value2) : this(value1)
        {
            this.value2 = value2;
        }
        public double CalculateSquareRoot()
        {
            return Math.Sqrt(value1 * value2);
        }
        public override string ToString()
        {
            return $"Информация об объекте: первое значение = {value1}, второе значение = {value2}";
        }
    }
}
