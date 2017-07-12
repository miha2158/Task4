using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Task4
{
    class Program
    {
        public static decimal f(long i)
        {
            decimal pow4 = 1;
            decimal pow5 = 25;

            for (long j = 0; j < i; j++)
            {
                pow4 = decimal.Multiply(pow4, 4);
                pow5 = decimal.Multiply(pow5, 5);
            }

            return decimal.Divide(1, decimal.Add(pow4, pow5));
        }

        static void Main(string[] args)
        {
            decimal result = 0;
            long num = 0;
            decimal precicion = 0.00001M;
            decimal el;

            WriteLine("Введите точность");
            while(!decimal.TryParse(ReadLine().Replace(".",","),out precicion) || precicion > 1 || precicion <=0)
                WriteLine("Ожидалось число между 0 и 1");

            do
            {
                el = f(num++);
                result = decimal.Add(result, el);
            }
            while (el > precicion);

            WriteLine("Результат: {0}",result);
            ReadKey(true);
        }
    }
}
