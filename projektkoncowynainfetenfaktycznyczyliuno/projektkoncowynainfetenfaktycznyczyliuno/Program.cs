using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projektkoncowynainfetenfaktycznyczyliuno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dialogi.poczotek();
            int ilekart = karty.ilekart();
            bool win1 = false;
            bool win2 = false;
            string[] cardsplayer1 = karty.shuffle(ilekart);
            string[] cardsplayer2 = karty.shuffle2(ilekart);
            Random rnd1 = new Random();
            string lastcard = karty.randomcard(rnd1);
            label2137:;
            Random rnd2 = new Random();
            if (lastcard.Contains("+4") || lastcard.Contains("chcol"))
            {
                lastcard = karty.randomcard(rnd2);
                goto label2137;
            }
            int n1 = 0;
            int n2 = 0;
            while (!win1 && !win2)
            {
                //start gracz 1
                label1:;
                for (int i = 0; i > cardsplayer1.Length; i++)
                {
                    if (cardsplayer1[i] == null)
                    {
                        n1++;
                    }
                }
                for (int i = 0; i > cardsplayer2.Length; i++)
                {
                    if (cardsplayer2[i] == null)
                    {
                        n2++;
                    }
                }
                if (n1 >= cardsplayer1.Length || n2 >= cardsplayer2.Length)
                {
                    if (n1>n2)
                    {
                        win1 = true;
                    }
                    if (n2>n1)
                    {
                        win2 = true;
                    } 
                }
                string odp1 = dialogi.gracz1(cardsplayer1,lastcard);
                Random rnd3 = new Random();
                for (int i = 0;i < cardsplayer1.Length; i++)
                {
                    if (cardsplayer1[i] == odp1 && karty.checkcard(lastcard,cardsplayer1[i]))
                    {
                        lastcard = cardsplayer1[i];
                        cardsplayer1[i] = null;
                        if (odp1 == "chcol" || odp1 == "+4")
                        {
                            Console.WriteLine("Jaki kolor wybierasz");
                            string odpkol1 = Console.ReadLine().ToLower();
                            lastcard += odpkol1;
                        }
                        string cz1 = karty.specjal(odp1);
                        if (cz1 == "skip"|| cz1 == "reverse")
                        {
                            goto label1;
                        }
                        if (cz1 == "+2")
                        {
                            for (int  j = 0;j < 2; j++)
                            {
                                for (int k = 0;k < cardsplayer2.Length; k++)
                                {
                                    if (cardsplayer2[k] == null)
                                    {
                                        cardsplayer2[k] = karty.randomcard(rnd3);
                                        break;
                                    }
                                }
                            }
                        }
                        Random rnd4 = new Random();
                        if (cz1 == "+4")
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                for (int k = 0; k < cardsplayer2.Length; k++)
                                {
                                    if (cardsplayer2[k] == null)
                                    {
                                        cardsplayer2[k] = karty.randomcard(rnd4);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                Random rnd5 = new Random();
                if (odp1 == "ciagne")
                {
                    for (int i = 0; i<cardsplayer1.Length ; i++)
                    {
                        string loskart = karty.randomcard(rnd5);
                        
                        if (cardsplayer1[i] == null)
                        {
                            cardsplayer1[i] = loskart;
                            break;  
                        }
                    }
                }
                //koniec gracz 1

                //start gracz 2
                label2:;
                for (int i = 0; i > cardsplayer1.Length; i++)
                {
                    if (cardsplayer1[i] == null)
                    {
                        n1++;
                    }
                }
                for (int i = 0; i > cardsplayer2.Length; i++)
                {
                    if (cardsplayer2[i] == null)
                    {
                        n2++;
                    }
                }
                if (n1 >= cardsplayer1.Length || n2 >= cardsplayer2.Length)
                {
                    if (n1 > n2)
                    {
                        win1 = true;
                    }
                    if (n2 > n1)
                    {
                        win2 = true;
                    }
                }
                string odp2 = dialogi.gracz2(cardsplayer2, lastcard);

                for (int i = 0; i < cardsplayer2.Length; i++)
                {
                    if (cardsplayer2[i] == odp2 && karty.checkcard(lastcard, cardsplayer2[i]))
                    {
                        lastcard = cardsplayer2[i];
                        cardsplayer2[i] = null;
                        if (odp2 == "chcol" || odp2 == "+4")
                        {
                            Console.WriteLine("Jaki kolor wybierasz");
                            string odpkol2 = Console.ReadLine().ToLower();
                            lastcard += odpkol2;  
                        }
                        string cz2 = karty.specjal(odp2);
                        Random rnd6 = new Random();
                        if (cz2 == "skip" || cz2 == "reverse")
                        {
                            goto label2;
                        }
                        if (cz2 == "+2")
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                for (int k = 0; k < cardsplayer1.Length; k++)
                                {
                                    if (cardsplayer1[k] == null)
                                    {
                                        cardsplayer1[k] = karty.randomcard(rnd6);
                                        break;
                                    }
                                }
                            }
                        }
                        Random rnd7 = new Random();
                        if (cz2 == "+4")
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                for (int k = 0; k < cardsplayer1.Length; k++)
                                {
                                    if (cardsplayer1[k] == null)
                                    {
                                        cardsplayer1[k] = karty.randomcard(rnd7);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                Random rnd8 = new Random();
                if (odp2 == "ciagne")
                {
                    for (int i = 0; i < cardsplayer2.Length; i++)
                    {
                        string loskart = karty.randomcard(rnd8);

                        if (cardsplayer2[i] == null)
                        {
                            cardsplayer2[i] = loskart;
                            break;
                        }
                    }
                }
                //koniec gracz 2
            }
            if (n1 >= cardsplayer1.Length || n2 >= cardsplayer2.Length)
            {
                if (n1 > n2)
                {
                    win1 = true;
                    
                }
                if (n2 > n1)
                {
                    win2 = true;
                    
                }
            }
            if (win1)
            {
                Console.WriteLine("Brawo Gracz1 wygrał");
            }
            if (win2)
            {
                Console.WriteLine("Brawo Gracz2 wygrał");
            }
            Console.ReadKey();
        }
    }
}
