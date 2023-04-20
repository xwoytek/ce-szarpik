using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace dokart
{
    internal class klasa
    {
        //Napisz metodę generująca tablicę z n. elementami ciągu.
        public static double[] zad1(int n)
        {
            double[] tablica = new double[n];
            double podst = 4.5;
            for (int i = 0; i < n; i++)
            {
                tablica[i] = podst;
                podst += 5;
            }
            return tablica;
        }
        public static void zad1inf()
        {
            string str = "";
            foreach (double item in zad1(int.Parse(Console.ReadLine())))
            {
                str += item;
                str += " == ";
            }
            Console.WriteLine(str);
        }
        //Zsumuj wszystkie elementy podzielne przez 5 (Metoda statyczna)
        public static void zad2(int n)
        {
            
            foreach (double item in klasa.zad1(n))
            {
                if (item % 5 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
        //Napisz też metodę statyczna która wyświetli element ciągu w jednej linijce.. (Metoda statyczna)
        public static void zad3()
        {
            klasa.zad1inf();
        }
        //Rozłóż  liczbę k na czynniki pierwsze.
        public static void zad4(int k)
        {
            bool prime = true;
            if (k <= 1)
            {
                prime = false;
            }
            for (int i = 2; i < k; i++)
            {
                if (k % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                Console.WriteLine($"{k} | {k}");
                Console.WriteLine("1");
            }
            if (!prime)
            {
                int n = 1;
                while (n != k)
                {
                    for (int i2 = 2; i2 <= k; i2++)
                    {


                        bool prime2 = true;
                        if (i2 <= 1)
                        {
                            prime2 = false;
                        }
                        for (int i = 2; i < i2; i++)
                        {
                            if (i2 % i == 0)
                            {
                                prime2 = false;
                                break;
                            }
                        }


                        if (k % i2 == 0 && prime2)
                        {
                            Console.WriteLine($"{k} | {i2}");
                            k /= i2;
                        }
                    }
                    
                    if (n == k)
                    {
                        Console.WriteLine("1");
                    }
                }
                
            }
        }
        //Zamień wszystkie elementy na liczby całkowite (rzutowanie). Dodaj do wszystkich elementów 1. 
        //Powiedz ile liczb pierwszych zawiera 10 elementowa tablica twojego ciągu.

        public static void zad5()
        {
            foreach (double item in klasa.zad1(10))
            {
                Console.WriteLine(Math.Round(item) + 1);
            }
            Console.WriteLine("========================");
            foreach (double item in klasa.zad1(10))
            {
                double inp = Math.Round(item) + 1;
                bool prime = true;
                if (inp <= 1)
                {
                    prime = false;
                }
                for (int i = 2; i < inp; i++)
                {
                    if (inp % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{inp} is {prime}");
                
            }

        }
        //Znajdź naj wspólny dzielnik liczby k i l
        public static void zad6()
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int kor = k;
            int lor = l;
            while (true)
            {
                if (k != l)
                {
                    if (k > l)
                    {
                        k -= l;
                    }
                    else
                    {
                        l -= k;
                    }
                }
                else
                {
                    Console.WriteLine($"NWD({kor},{lor}) = {k}");
                    break;
                }
            }
        }
    }
}
