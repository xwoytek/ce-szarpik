using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace projektkoncowynainfetenfaktycznyczyliuno
{
    internal class karty
    {
        public static string[] shuffle(int a)
        {
            Random rnd = new Random();
            string[] listakart =
                {
                "cz0","cz1", "cz2", "cz3", "cz4", "cz5", "cz6", "cz7", "cz8", "cz9", "czskip", "czreverse", "cz+2",
                "y0", "y1", "y2", "y3", "y4", "y5", "y6", "y7", "y8", "y9", "yskip", "yreverse", "y+2",
                "b0", "b1", "b2", "b3", "b4", "b5", "b6", "b7", "b8", "b9", "bskip", "breverse", "b+2",
                "g0", "g1", "g2", "g3", "g4", "g5", "g6", "g7", "g8", "g9", "gskip", "greverse", "g+2",
                "chcol", "+4"
            };
            string[] karty = new string[100];



            for (int i = 0; i < a; i++)
            {
                karty[i] = listakart[rnd.Next(listakart.Length)];
            }
            for (int i = 0;i < karty.Length; i++)
            {
                if (karty[i] == "")
                {
                    karty[i] = null;
                }
            }
            return karty;
        }
        public static string[] shuffle2(int a)
        {
            
            Random rnd2 = new Random();
            string[] listakart =
                {
                "cz0","cz1", "cz2", "cz3", "cz4", "cz5", "cz6", "cz7", "cz8", "cz9", "czskip", "czreverse", "cz+2",
                "y0", "y1", "y2", "y3", "y4", "y5", "y6", "y7", "y8", "y9", "yskip", "yreverse", "y+2",
                "b0", "b1", "b2", "b3", "b4", "b5", "b6", "b7", "b8", "b9", "bskip", "breverse", "b+2",
                "g0", "g1", "g2", "g3", "g4", "g5", "g6", "g7", "g8", "g9", "gskip", "greverse", "g+2",
                "chcol", "+4"
            };
            string[] karty = new string[100];
            int random = rnd2.Next(listakart.Length);


            for (int j = 0 ; j < a; j++)
            {
                for (int i = 0; i < a; i++)
                {
                    karty[i] = listakart[rnd2.Next(listakart.Length)];
                }
            }
            
            for (int i = 0; i < karty.Length; i++)
            {
                if (karty[i] == "")
                {
                    karty[i] = null;
                }
            }
            return karty;
        }
        public static int ilekart()
        {
            Console.WriteLine("Ile kart startowo?");
            Console.WriteLine("Max 100 kart");
            int ilekart = int.Parse(Console.ReadLine());
            return ilekart;
        }
        
        public static string randomcard(Random rnd)
        {
            

            string[] listakart =
                {
                "cz0","cz1", "cz2", "cz3", "cz4", "cz5", "cz6", "cz7", "cz8", "cz9", "czskip", "czreverse", "cz+2",
                "y0", "y1", "y2", "y3", "y4", "y5", "y6", "y7", "y8", "y9", "yskip", "yreverse", "y+2",
                "b0", "b1", "b2", "b3", "b4", "b5", "b6", "b7", "b8", "b9", "bskip", "breverse", "b+2",
                "g0", "g1", "g2", "g3", "g4", "g5", "g6", "g7", "g8", "g9", "gskip", "greverse", "g+2",
                "chcol", "+4"
            };
            int liczba = rnd.Next(listakart.Length);
            
            
            string karta = listakart[liczba];
            return karta;
        }
        public static bool checkcard(string a,string b)
        {
            bool czy = false;
            if (b.Contains("cz") && a.Contains("cz"))
            {
                czy = true;
            }
            if (b.Contains("b") && a.Contains("b"))
            {
                czy = true;
            }
            if (b.Contains("y") && a.Contains("y"))
            {
                czy = true;
            }
            if (b.Contains("g") && a.Contains("g"))
            {
                czy = true;
            }
            if (b.Contains("0") && a.Contains("0"))
            {
                czy = true;
            }
            if (b.Contains("1") && a.Contains("1"))
            {
                czy = true;
            }
            if (b.Contains("2") && a.Contains("2"))
            {
                czy = true;
            }
            if (b.Contains("3") && a.Contains("3"))
            {
                czy = true;
            }
            if (b.Contains("4") && a.Contains("4"))
            {
                czy = true;
            }
            if (b.Contains("5") && a.Contains("5"))
            {
                czy = true;
            }
            if (b.Contains("6") && a.Contains("6"))
            {
                czy = true;
            }
            if (b.Contains("7") && a.Contains("7"))
            {
                czy = true;
            }
            if (b.Contains("8") && a.Contains("8"))    
            {
                czy = true;
            }
            if (b.Contains("9") && a.Contains("9"))
            {
                czy = true;
            }
            if (b.Contains("skip") && a.Contains("skip"))
            {
                czy = true;
            }
            if (b.Contains("reverse") && a.Contains("reverse"))
            {
                czy = true;
            }
            if (b.Contains("+2") && a.Contains("+2"))
            {
                czy = true;
            }
            if (b.Contains("chcol"))
            {
                czy = true;
            }
            if (b.Contains("+4"))
            {
                czy = true;
            }
            
            return czy;

        }
        public static string specjal(string a)
        {
            string czynnosc = "";
            if (a.Contains("skip"))
            {
                czynnosc = "skip";
            }
            if (a.Contains("reverse"))
            {
                czynnosc = "reverse";
            }
            if (a.Contains("+2"))
            {
                czynnosc = "+2";
            }
            if (a.Contains("+4"))
            {
                czynnosc = "+4";
            }
            return czynnosc;
        }
    }

}
