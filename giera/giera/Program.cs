using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static giera.Moby;

namespace giera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imjedemon = systems.losimie();
            string[] itemy = { "", "", "" };
            string skinnoza;
            skinnoza = karambit.losowanie();
            bool bul = false;
            Dialogi.Intro();
            Rycer ryc = new Rycer(100, 10, 0, itemy, 0, Dialogi.imje());
            DEMONPIEKELNY demon = new DEMONPIEKELNY(50 + systems.rand(-20, 20), 10 + systems.rand(-3, 2), systems.rand(1, 10));
            while (false)
            {
                Console.WriteLine("haha śmieszne while false hahahaha");
            }
            while (ryc.Hp > 0)
            {
                if (demon.Hp <= 0)
                {
                    ryc.Coiny += demon.Coins;
                    demon = new DEMONPIEKELNY(50 + systems.rand(-20, 20), 10+systems.rand(-3,2), systems.rand(1, 10));
                    imjedemon = systems.losimie();
                }
                systems.Checkkill(ryc.Killcount);
                
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Dialogi.bitwapodgrunwaldem(ryc.IMJIE, ryc.Hp, ryc.Damage, ryc.Coiny, ryc.Items, ryc.Killcount, imjedemon, demon.Hp, demon.Damage, demon.LVL,demon.Coins);
                Console.WriteLine("\n");
                int odp = Dialogi.odpo();
                switch(odp)
                {
                    case 1:
                        
                        int odp2 = Dialogi.odpo2();
                        if (odp2 == 1)
                        {
                            bul = true;
                            Console.WriteLine($"Atakujesz {imjedemon} za {ryc.Damage}");
                            demon.Hp -= ryc.Damage;
                        }
                        if (odp2 == 2)
                        {
                            bul = true;
                            if (ryc.Items.Contains("noz"))
                            {
                                Console.WriteLine($"Atakujesz {imjedemon} swoim {skinnoza} z csa za {ryc.Damage*2}");
                                demon.Hp -= ryc.Damage*2;
                            }
                            if (!ryc.Items.Contains("noz"))
                            {
                                Console.WriteLine("Nie masz miecza debilu");
                                Console.ReadLine();
                            }
                        }
                        if (odp2 == 3)
                        {
                            bul = true;
                            if (ryc.Items.Contains("patyk"))
                            {
                                int rnd = systems.rand(1,10);
                                if (systems.rand(1, 5) == 3)
                                {
                                    Console.WriteLine($"Tfoja magia działa i ukradłeś {imjedemon} {rnd} hp");
                                    demon.Hp -= rnd;
                                    ryc.Hp += rnd;
                                }
                                
                            }
                            if (!ryc.Items.Contains("patyk"))
                            {
                                Console.WriteLine("Nie jesteś jakimś gandalfem debilu");
                                Console.ReadLine();
                            }
                        }
                        else if (bul == false)
                        {
                            Console.WriteLine("Ty analfabeto");
                            Console.ReadLine();
                        }
                        bul = false;
                        if (demon.Hp > 0)
                        {
                            Console.WriteLine($"{imjedemon} atakuje cie za {demon.Damage}");
                            ryc.Hp -= demon.Damage;
                        }
                        break;
                    case 2:
                        ryc.Hp += systems.hilf(ryc.Items);
                        break;
                    case 3:
                        string[] ityraz = ryc.Items;
                        ryc.Items = sklep.rundawsklepie(ryc.Items,ryc.Coiny);
                        if (ryc.Items.Contains("noz") && !ityraz.Contains("noz"))
                        {
                            ryc.Coiny -= 10;
                        }
                        if (ryc.Items.Contains("patyk") && !ityraz.Contains("patyk"))
                        {
                            ryc.Coiny -= 20;
                        }
                        if (ryc.Items.Contains("heal") && !ityraz.Contains("heal"))
                        {
                            ryc.Coiny -= 5;
                        }
                        break;
                }
            }
        }
    }
}
  