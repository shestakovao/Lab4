using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительные числа A, B, C");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int tempA = 0;
            int tempB = 0;
            int countSquad = 0;

            while (tempB+c <= b)
            {
                tempA = 0;
                while (tempA+c <= a)
                {               
                    tempA += c;
                    countSquad++;
                }
                tempB += c;
            }

            Console.WriteLine("Количество квадратов равно {0}", countSquad);
            Console.ReadKey();
        }
    }
}
