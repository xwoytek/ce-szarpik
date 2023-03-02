using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bryly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("co liczysz: 1  - pole kola, 2 - obwod kola, 3 - pole elipsy, 4 - powierzchnie kuli, 5 - objętość kuli, 6 - objętość walca, 7 - objętość stożka");
            int wybor = int.Parse(Console.ReadLine());
            if (wybor == 1)
            {
                Console.WriteLine("dej r");
                int r = int.Parse(Console.ReadLine());
                double wynik = Math.PI * r * r;
                Console.WriteLine($"wynik to : {wynik}");
                
            }
            if (wybor == 2)
            {
                Console.WriteLine("dej r");
                int r = int.Parse(Console.ReadLine());
                double wynik = Math.PI * r * 2;
                Console.WriteLine($"wynik to : {wynik}");
            }
            if (wybor == 3)
            {
                Console.WriteLine("dej a");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("dej b");
                int b = int.Parse(Console.ReadLine());
                double wynik = Math.PI * a * b;
                Console.WriteLine($"wynik to : {wynik}");
            }
            if (wybor == 4)
            {
                Console.WriteLine("dej r");
                int r = int.Parse(Console.ReadLine());
                double wynik = Math.PI * r * r * 4;
                Console.WriteLine($"wynik to : {wynik}");
            }
            if (wybor == 5)
            {
                Console.WriteLine("dej r");
                int r = int.Parse(Console.ReadLine());
                double wynik = Math.PI * r * r * r * (4/3);
                Console.WriteLine($"wynik to : {wynik}");
            }
            if (wybor == 6)
            {
                Console.WriteLine("dej r");
                int r = int.Parse(Console.ReadLine());
                Console.WriteLine("dej h");
                int h = int.Parse(Console.ReadLine());
                double wynik = Math.PI * r * r * h;
                Console.WriteLine($"wynik to : {wynik}");
            }
            if (wybor == 7)
            {
                Console.WriteLine("dej r");
                int r = int.Parse(Console.ReadLine());
                Console.WriteLine("dej h");
                int h = int.Parse(Console.ReadLine());
                double wynik = Math.PI * r * r * h * 1/3;
                Console.WriteLine($"wynik to : {wynik}");
            }
            Console.ReadLine();
        }
    }
}
