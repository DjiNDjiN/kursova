﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 377|2: Да се въведат от клавиатурата 13 числа. Да се намери и отпечата на екрана средноаритметичното на тези от тях, които отговарят на следното условие: да са положителни или по-малки от -300.");
            List<int> numbers = new List<int>();
            int avg = 0;
            Console.WriteLine("Въведете 13 числа:");
            for (int i = 0; i < 13; i++)
            {
                
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum > 0 || currentNum < -300)
                {
                    numbers.Add(currentNum);
                }
            }

            avg = numbers.Sum() / numbers.Count;
            Console.Write("Средно аритметично: " + avg);

        }
    }
}
