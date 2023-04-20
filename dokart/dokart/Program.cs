using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dokart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ktore zadanie");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    klasa.zad1inf();
                    break;
                case 2:
                    klasa.zad2(int.Parse(Console.ReadLine()));
                    break;
                case 3:
                    klasa.zad3();
                    break;
                case 4:
                    klasa.zad4(int.Parse(Console.ReadLine()));
                    break;
                case 5:
                    klasa.zad5();
                    break;
                case 6:
                    klasa.zad6();
                    break;
            }
            Console.ReadLine();  
        }
    }
}
