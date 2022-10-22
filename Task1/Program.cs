using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N>0");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    sum += 2 * i - 1;
                    Console.WriteLine("Квадрат {0} равен {1}", i, sum);
                }
                    
            }
            else
            { Console.WriteLine("N должно быть больше нуля"); }
            Console.ReadKey();
        }
    }
}
