using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задача 36|ж: Запишете израз, който е истина при изпълнение на указаното условие и лъжа в противен случай: Ж) нито едно от числата x, y и z не е положително;");
            Console.WriteLine("Въведете стойност за x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете стойност за y:");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете стойност за z:");
            double z = double.Parse(Console.ReadLine());

            if (x < 0 && y < 0 && z < 0)
                {
                Console.WriteLine("True");
                }

            else
                {
                Console.WriteLine("False");
                }

        }
    }
}
