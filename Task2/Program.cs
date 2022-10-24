using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPluse = 0;
            int countMinus = 0;
            int currentNumber;
            Console.WriteLine("вводите числа для завершения введите 0");
            do
            {
                currentNumber = Convert.ToInt32(Console.ReadLine());
                if (currentNumber < 0) { countMinus++; }
                if (currentNumber > 0) { countPluse++; }
            }
            while (currentNumber != 0);
            Console.WriteLine("Количество отрицательных чисел {0} количество положительных {1}", countMinus, countPluse);

            if (countMinus == countPluse)
            {
                Console.WriteLine("Количество отрицательных чисел равно количеству положительных");
            }
            else
            {
                if (countMinus < countPluse)
                { 
                    Console.WriteLine("Количество отрицательных чисел меньше количества положительных"); 
                }
                else
                { 
                    Console.WriteLine("Количество отрицательных чисел больше количества положительных"); 
                }
            }
            Console.ReadKey();
        }
    }
}
