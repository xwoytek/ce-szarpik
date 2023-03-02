using System;

namespace pracazinfykalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Co robisz? 1 - dodajesz, 2 - odejmujesz, 3 - mnozysz, 4 - dzielisz");
            int wybor = int.Parse(Console.ReadLine());
            if (wybor == 1)
            {
                Console.WriteLine("dej a");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("dej b");
                int b = int.Parse(Console.ReadLine());
                int wynik = a + b;
                if (a == 2 && b == 2)
                {
                    Console.WriteLine($"2 + 2 = 5");
                }
                if (a != 2 && b != 2)
                {
                    Console.WriteLine($"{a} + {b} = {wynik}");
                }

            }
            if (wybor == 2)
            {
                Console.WriteLine("dej a");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("dej b");
                int b = int.Parse(Console.ReadLine());
                int wynik = a - b;
                Console.WriteLine(wynik);
                Console.WriteLine($"{a} + {b} = {wynik}");
            }
            if (wybor == 3)
            {
                Console.WriteLine("dej a");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("dej a");
                int b = int.Parse(Console.ReadLine());
                int wynik = a * b;
                Console.WriteLine(wynik);
                Console.WriteLine($"{a} + {b} = {wynik}");
            }
            if (wybor == 4)
            {
                Console.WriteLine("dej a");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("dej a");
                int b = int.Parse(Console.ReadLine());
                int wynik = a / b;
                Console.WriteLine(wynik);
                Console.WriteLine($"{a} + {b} = {wynik}");
            }
            Console.ReadLine();
        }
    }
}
