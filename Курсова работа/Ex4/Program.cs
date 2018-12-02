using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 213|ж: Да се изчисли: tg(1+tg(2+tg(3+…+tg(99+tg(100))…))).");
            
            double next = 0.0;


            for (int i = 100; i > 0; i --)       
            {                
                next = Math.Tan(i + next);
                
                Console.WriteLine(next);
            }
            
        }
    }
}
