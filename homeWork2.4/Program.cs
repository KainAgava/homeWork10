using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork2._4
{
    internal class Program { }


    namespace Example
    {
        internal static class Program
        {
            static void Main(string[] args)
            {
                int number;
                int randomNumberMin = 1000;
                int randomNumberMax = 100000;

                Random random = new Random();
                number = random.Next(randomNumberMin, randomNumberMax);

                int multipleOfThree = 3;
                int multipleOfFive = 5;
                int value = 0;

                for (int i = 0; i <= number; i++)
                {
                    if (i % multipleOfThree == 0 || i % multipleOfFive == 0)
                    {
                        Console.WriteLine(i);
                        value += i;
                    }
                }
                Console.WriteLine($"Случайное число {number}");
                Console.WriteLine($"Сумма {value} ");
            }
        }
    }
}

