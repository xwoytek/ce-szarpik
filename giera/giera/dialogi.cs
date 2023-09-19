using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace giera
{
    internal class Dialogi
    {
        public static void Miejsce(string placek)
        {
            Console.WriteLine("■■■■■■■■■■■■■■■");
            Console.WriteLine(placek);
            Console.WriteLine("■■■■■■■■■■■■■■■");
            Console.ReadLine();
        }
        public static string imje()
        {
            string imje = Console.ReadLine();
            return imje;
        }
        public static void Statywy(string imje,int hp, int damage,int coins, string items, int killcount)
        {
            Console.WriteLine($"Teraz {imje} ma:");
            Console.WriteLine($"{hp} hp");
            Console.WriteLine($"{coins} Rubli");
            Console.WriteLine($"W plecaku masz {items}");
            Console.WriteLine($"Zadajesz {damage} damage'a");
            Console.WriteLine($"Zabiłeś już {killcount} demonów");
        }
        public static void Intro()
        {
            Console.WriteLine("Witaj");
            Console.WriteLine("Nie pytaj kim jestem");
            Console.WriteLine("Po prostu uciekaj");
            Console.WriteLine("A i jak się nazywasz?");
        }
        public static int odpo()
        {
            Console.WriteLine("co robisz?");
            Console.WriteLine("1 - atak 2 - heal 3 - sklep");
            return int.Parse( Console.ReadLine() );
        }
        public static int odpo2()
        {
            Console.WriteLine("Jak atakujesz??");
            Console.WriteLine("1- łapami 2 - mieczem 3 - patykiem");
            return int.Parse(Console.ReadLine());
        }
        public static void introwalka(string imjedemon)
        {
            Console.WriteLine($"Teraz walczysz z {imjedemon}");
        }
        public static void statydemon(int hp, int dam,int lvl,int coiny)
        {
            
            Console.WriteLine($"on ma {hp} hp");
            Console.WriteLine($"ma {lvl} level");
            Console.WriteLine($"i zadaje {dam} demedża");
            Console.WriteLine($"za jego zabicie dostaniesz {coiny} rubli");

        }
        public static void bitwapodgrunwaldem(string imije, 
            int hp, 
            int damage , 
            int coins, 
            string[] ity , 
            int killcount,
            string imjedemon,
            int hape , 
            int dam,
            int lvl,
            int coinydemo)
        {
            Statywy(imije,hp,damage,coins,systems.ity(ity),killcount);
            Console.WriteLine("\n");
            introwalka(imjedemon);
            statydemon(hape,dam,lvl,coinydemo);
        }
    }
}
 