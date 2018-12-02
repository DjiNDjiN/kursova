﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            PrintOnConsole(DoMySplit(ReadStringFromConsole()));
            PrintOnConsole(DoMySplit(ReadStringFromConsole()));

        }       

        static string ReadStringFromConsole()
        {
            Console.WriteLine("Задача 363: Съставете програма, която заменя цифрова уникод последователност със съответния текст. Уникодът на „А“ е 1040, а уникодовете от текста имат префикс „&#“ и суфикс „;“. Ето и двата примера:");
            Console.WriteLine("&#1075;&#1088;&#1072;&#1076; (град)");
            Console.WriteLine("&#1055;&#1083;&#1086;&#1074;&#1076;&#1080;&#1074; (Пловдив)");
            Console.Write("Моля въведете уникод:");
            string inputString = Console.ReadLine();
            return inputString;
        }
        static string[] DoMySplit(string inputString)
        {
            int count = 100;
            
            string[] characters = inputString.Split("&#", count);
            
            for (int i = 0; i < characters.Length; i++)
            {
                Console.Write(characters[i]);
            }
            return characters;
        }
        static void PrintOnConsole(string[] characters)
        {
            for (int i = 0; i < characters.Length; i++)
            {
                Console.Write(GetUnicodeSymbol(characters[i]));
            }
        }
        static char? GetUnicodeSymbol(string unicode)
        {
            Nullable<char> symbol;
            switch (unicode)
            {
                case "1075;":
                    symbol = 'г';
                    break;
                case "1088;":
                    symbol = 'р';
                    break;
                case "1072;":
                    symbol = 'а';
                    break;
                case "1076;":
                    symbol = 'д';
                    break;
                case "1055;":
                    symbol = 'П';
                    break;
                case "1083;":
                    symbol = 'л';
                    break;
                case "1086;":
                    symbol = 'о';
                    break;
                case "1074;":
                    symbol = 'в';
                    break;
                case "1080;":
                    symbol = 'и';
                    break;
                default:
                    symbol = null;
                    break;
            }
            return symbol;
        }

    }
}
