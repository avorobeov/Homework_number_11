using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            const int NumberToAdd1 = 3;
            const int NumberToAdd2 = 5;
            int maximumNumber = 100;
            int minimalNumber = 0;
            int randomNumber =7/* random.Next(minimalNumber, maximumNumber)*/;
            int sumNumbers = 0;

            for (int i = minimalNumber; i <= randomNumber; i++)
            {
                if (i % NumberToAdd1 == 0 || i % NumberToAdd2 == 0)
                {
                    sumNumbers += i;
                }
            }

            Console.WriteLine($"Рандомно сгенерированное число: {randomNumber} \nСумма чисел: {sumNumbers}");
            Console.ReadLine();
        }
    }
}
