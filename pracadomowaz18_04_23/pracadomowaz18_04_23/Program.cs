using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracadomowaz18_04_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 - pole kwadratu, 1 - pole prostokata, 2 - pole trojkata, 3 - pole rownolegloboku, 4 - pole trapezu, 5 - pole kola, 6 - objetosc szescianu,");
            Console.WriteLine("7 - objetosc prostopadloscianu, 8 - objetosc walca, 9 - objetosc kuli, 10 - pole powierzchni szescianu, 11 - pole powierzchni prostopadloscianu, 12 - pole powierzchni walca");
            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 0:
                    Console.WriteLine("dej a");
                    Console.WriteLine(wzory.pkwadratu(int.Parse(Console.ReadLine())));
                    break;
                case 1:
                    Console.WriteLine("dej a,b");
                    Console.WriteLine(wzory.pprostokata(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())));
                    break;
                case 2:
                    Console.WriteLine("dej a,h");
                    Console.WriteLine(wzory.ptrjkt(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    break;
                case 3:
                    Console.WriteLine("dej a,h");
                    Console.WriteLine(wzory.prowno(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    break;
                case 4:
                    Console.WriteLine("dej a,b,c");
                    Console.WriteLine(wzory.ptrapez(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    break;
                case 5:
                    Console.WriteLine("dej r");
                    Console.WriteLine(wzory.pkola(int.Parse(Console.ReadLine())));
                    break;
                case 6:
                    Console.WriteLine("dej a");
                    Console.WriteLine(wzory.objszesc(int.Parse(Console.ReadLine())));
                    break;
                case 7:
                    Console.WriteLine("dej a,b,c");
                    Console.WriteLine(wzory.objprostopadloscianu(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    break;
                case 8:
                    Console.WriteLine("dej r,h");
                    Console.WriteLine(wzory.objwalca(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    break;
                case 9:
                    Console.WriteLine("dej r");
                    Console.WriteLine(wzory.objkuli(int.Parse(Console.ReadLine())));
                    break;
                case 10:
                    Console.WriteLine("dej a");
                    Console.WriteLine(wzory.pszesc(int.Parse(Console.ReadLine())));
                    break;
                case 11:
                    Console.WriteLine("dej a,b,c");
                    Console.WriteLine(wzory.pprostopadl(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    break;
                case 12:
                    Console.WriteLine("dej r,h");
                    Console.WriteLine(wzory.pwalca(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    break;
                
            }
            Console.ReadLine();
        }
    }
}
