using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giera
{
    internal class sklep
    {
        public class Sklep
        {
            public int Cenaharyportfel;
            public int Cenanoz;
            public int Cenawlodzimierz;
            public Sklep(int cenaharyportfel, int cenanoz, int cenawlodzimierz)
            {
                Cenaharyportfel = cenaharyportfel;
                Cenanoz = cenanoz;
                Cenawlodzimierz = cenawlodzimierz;
            }

        }
        public static string[] rundawsklepie(string[] itemy, int boliwary)
        {
            bool triu = false;
            Sklep a = new Sklep(20, 10, 5);
            
            while (true)
            {
                Console.WriteLine("Jesteś w żabce co kupujesz?");
                Console.WriteLine("Mieczora,patyk, czy wcaleniekryształki TM");
                Console.WriteLine("(miecz , patyk , heal , koniec)");
                string odp = Console.ReadLine();
                if (odp == "koniec")
                {
                    break;
                }
                
                if (odp == "miecz")
                {
                    triu = true;
                    Console.WriteLine($"Ok to bedzię kosztować {a.Cenanoz}");
                    Console.WriteLine($"Ty masz {boliwary} rubli");
                    Console.WriteLine("Kupujesz?");
                    string odp2 = Console.ReadLine();
                    odp2.ToLower();
                    
                    if (odp2 == "tak" && !itemy.Contains("noz"))
                    {
                        
                        if (boliwary < a.Cenanoz)
                        {
                            Console.WriteLine("brakuje ci hajsu");
                        }
                        if (itemy.Contains("noz"))
                        {
                            Console.WriteLine("Już to masz");
                        }
                        if (boliwary >= a.Cenanoz)
                        {
                            itemy[0] = "noz";
                            Console.WriteLine("kupione");
                        }
                    }
                    if (odp2 == "nie")
                    {

                    }

                }
                triu = true;
                if (odp == "patyk")
                {
                    Console.WriteLine($"Ok to bedzię kosztować {a.Cenaharyportfel}");
                    Console.WriteLine($"Ty masz {boliwary} rubli");
                    Console.WriteLine("Kupujesz?");
                    string odp2 = Console.ReadLine();
                    odp2.ToLower();
                    if (odp2 == "tak")
                    {
                        
                        if (boliwary < a.Cenaharyportfel)
                        {
                            Console.WriteLine("brakuje ci hajsu");
                        }   
                        if (itemy.Contains("patyk"))
                        {
                            Console.WriteLine("Już to masz");
                        }
                        if (boliwary > a.Cenaharyportfel && !itemy.Contains("patyk"))
                        {
                            itemy[1] = "patyk";
                            Console.WriteLine("Kupione");
                        }

                    }
                    if (odp2 == "nie")
                    {

                    }
                }
                if (odp == "heal")
                {
                    triu = true;
                    Console.WriteLine($"Ok to bedzię kosztować {a.Cenawlodzimierz}");
                    Console.WriteLine($"Ty masz {boliwary} rubli");
                    Console.WriteLine("Kupujesz?");
                    string odp3 = Console.ReadLine();
                    odp3.ToLower();
                    if (odp3 == "tak")
                    {
                        
                        if (boliwary < a.Cenawlodzimierz)
                        {
                            Console.WriteLine("brakuje ci hajsu");
                        }
                        if (itemy.Contains("heal"))
                        {
                            Console.WriteLine("Już to masz");
                        }
                        if (boliwary > a.Cenawlodzimierz && !itemy.Contains("heal"))
                        {
                            itemy[2] = "heal";
                            Console.WriteLine("kupione");

                        }
                    }
                    if (odp3 == "nie")
                    {

                    }

                }
                else if (triu == false)
                {
                    Console.WriteLine("eeee co?");
                    
                }
                triu = false;

            }
            return itemy;
        }
    }
}