using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_3
{
    class Program
    {
        static int Pro(int k)
        {
            Console.WriteLine("Задача 377|3: Да се създаде метод  Pro(k), който генерира kна брой случайни цели числа и като резултат връща произведението на тези от тях, които са в интервала [-10, 10]. В главния метод да се въведат 3 цели положителни числа  а, b и c. Да се намери и отпечата: Pro(│a-b│)*Pro(c).");
            Random rand = new Random();
            List<int> numbers = new List<int>();
            int result = 1;

            for (int i = 0; i < k; i++)
            {
                int currentNum = rand.Next(-100, 100);

                if (currentNum > -10 && currentNum < 10)
                {
                    numbers.Add(currentNum);
                }
            }

            foreach (int num in numbers)
            {
                result *= num;
            }

            return result;
        }

        static void Main(string[] args)
        {

            int a = 15;
            int b = 30;
            int c = 10;

            Console.WriteLine(Pro(Math.Abs(a - b)) * Pro(c));

        }
    }
}
