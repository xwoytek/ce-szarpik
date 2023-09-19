using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giera
{
    internal class systems
    {
        public static void Checkkill(int kills)
        {
            if (kills <= 5)
            {
                Dialogi.Miejsce("Zamek");
            } 
            if (kills <= 10 && kills>5)
            {
                Dialogi.Miejsce("Miasto");
            }
            if (kills <= 20 && kills > 10)
            {
                Dialogi.Miejsce("Ciemny las");
            }
            if (kills <= 30 && kills > 20)
            {
                Dialogi.Miejsce("Ciemniejszy las");
            }
            if (kills > 30)
            {
                Dialogi.Miejsce("Najciemniejszy las");
            }

        }
        public static int rand(int minimum,int maximum)
        {
            Random rnd = new Random();
            return rnd.Next(minimum, maximum);
        }
        public static string ity(string[] itemy)
        {
            string itey;
            itey = "";
            foreach (string item in itemy)
            {
                itey += item;
                itey += " ";
            }
            return itey;
        }
        public static int hilf(string[] itemy)
        {
         if (itemy.Contains("heal"))
         {
                itemy[2] = "";
                Console.WriteLine("Pomyślnie uleczono");
                return 15;

         }
         else
         {
                Console.WriteLine("nie masz wcaleniekryształki TM");
                return 0;
         }
         
        }
        public static string losimie()
        {
            string[] listajimjion = {"belzedup", "lukier", "demon", "ten gość z halo", "demonslejer", "olek", "gaijin snail", "niewolnik", "EA", };
            Random rnd = new Random();
            int i = rnd.Next(listajimjion.Count());
            return listajimjion[i];
        }
    }

}
