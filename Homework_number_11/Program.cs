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
            int maximumNumber = 101;
            int minimalNumber = 0;
            int randomNumber = random.Next(minimalNumber, maximumNumber);
            int sumNumbers = 0;

            for (int i = minimalNumber; i <= randomNumber; i++)
            {
                switch (i)
                {
                    case NumberToAdd1:
                    case NumberToAdd2:
                        sumNumbers += i;
                        break;
                }
            }

            Console.WriteLine($"Рандомно сгенерированное число: {randomNumber} \nСумма чисел: {sumNumbers}");
            Console.ReadLine();
        }
    }
}
