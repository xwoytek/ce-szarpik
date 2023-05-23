using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projektkoncowynainfetenfaktycznyczyliuno
{
    internal class dialogi
    {
        public static void poczotek()
        {
            Console.WriteLine("Witaj w grze UNO!");
            Console.WriteLine("Jest to gra dwuosobowa");
            
        }
        public static string gracz1(string[] a,string b)
        {
            
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Teraz Gracz 1");
            Console.ReadLine();
            
            foreach (string card in a)
            {
                karta(card);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("To są twoje karty");
            lastcard(b);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\njaką karte dajesz czy ciągnies?");
            string odp = Console.ReadLine().ToLower();
            return odp;
            
            
        } 
        public static string gracz2(string[] a,string b)
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Teraz Gracz 2");
            Console.ReadLine();
            foreach (string card in a)
            {
                karta(card);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("To są twoje karty");
            lastcard(b);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\njaką karte dajesz czy ciągniesz?");
            string odp = Console.ReadLine().ToLower();
            return odp;
        }
        public static void karta(string b)
        {
            string a = "";
            if (b == null)
            {
                goto Label;
            }
            if (b.Contains("cz"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (b.Contains("b"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            if (b.Contains("y"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            if (b.Contains("g"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            if (b.Contains("0"))
            {
                a = "0";
            }
            if (b.Contains("1"))
            {
                a = "1";
            }
            if (b.Contains("2"))
            {
                a = "2";
            }
            if (b.Contains("3"))
            {
                a = "3";
            }
            if (b.Contains("4"))
            {
                a = "4";
            }
            if (b.Contains("5"))
            {
                a = "5";
            }
            if (b.Contains("6"))
            {
                a = "6";
            }
            if (b.Contains("7"))
            {
                a = "7";
            }
            if (b.Contains("8"))
            {
                a = "8";
            }
            if (b.Contains("9"))
            {
                a = "9";
            }
            if (b.Contains("skip"))
            {
                a = "o";
            }
            if (b.Contains("reverse"))
            {
                a = "$";
            }
            if (b.Contains("+2"))
            {
                a = "Z";
            }
            if (b.Contains("+4"))
            {
                Console.ForegroundColor = ConsoleColor.White;
                a = "A";
                if (b.Contains("cz"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (b.Contains("b"))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                if (b.Contains("y"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (b.Contains("g"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
            if (b.Contains("chcol"))
            {
                Console.ForegroundColor = ConsoleColor.White;
                a = "C";
                if (b.Contains("cz"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (b.Contains("b"))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                if (b.Contains("y"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (b.Contains("g"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"{a}--------{a}", Console.ForegroundColor);
            Console.WriteLine($"|        |", Console.ForegroundColor);
            Console.WriteLine($"|        |", Console.ForegroundColor);
            Console.WriteLine($"|        |", Console.ForegroundColor);
            Console.WriteLine($"|   {a}    |", Console.ForegroundColor);
            Console.WriteLine($"|        |", Console.ForegroundColor);
            Console.WriteLine($"|        |", Console.ForegroundColor);
            Console.WriteLine($"|        |", Console.ForegroundColor);
            Console.WriteLine($"{a}--------{a}", Console.ForegroundColor);
            Console.WriteLine($"^Ta karta to {b}^");
            Label:;
        }
        public static void lastcard(string a)
        {
            Console.WriteLine("Ostatnia karta to  VVV");
            karta(a);
            Console.WriteLine("Ostatnia karta to  ^^^");
        }


    }
}
