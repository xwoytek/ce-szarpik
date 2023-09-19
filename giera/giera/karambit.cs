using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giera
{
    internal class karambit
    {
        public static string losowanie()
        {
            string[] typynoza = { 
                "Bayonet", 
                "Bowie", 
                "Butterfly", 
                "Falchion", 
                "Flip", 
                "Gut", 
                "Huntsman", 
                "Karambit", 
                "M9 Bayonet", 
                "Navaja", 
                "Nomad", 
                "Paracord", 
                "Shadow Daggers", 
                "Skeleton", 
                "Stiletto", 
                "Survival", 
                "Talon", 
                "Ursus" };
            string[] skiny = { 
                "Vanilla", 
                "Gamma Doppler Phase 1", 
                "Gamma Doppler Phase 2", 
                "Gamma Doppler Phase 3", 
                "Gamma Doppler Phase 4", 
                "Gamma Doppler Emerald", 
                "Lore", 
                "Autotronic", 
                "Black Laminate", 
                "Freehand", 
                "Bright Water", 
                "Marble Fade", 
                "Tiger Tooth", 
                "Doppler Phase 1", 
                "Doppler Phase 2", 
                "Doppler Phase 3", 
                "Doppler Phase 4", 
                "Doppler Ruby", 
                "Doppler Sapphire", 
                "Doppler Black Pearl", 
                "Damascus Steel", 
                "Rust Coat", 
                "Ultraviolet",
                "Slaughter", 
                "Fade", 
                "Case hardened", 
                "Night", 
                "Crimson Web", 
                "Stained", 
                "Blue Steel", 
                "Urban Masked", 
                "Forest DDPAT", 
                "Safari Mesh", 
                "Boreal Forest", 
                "Scorched" };
            
            string skin;
            string typnoza;
            string noza;
            
            Random rnd = new Random();
            Random rnd2 = new Random();
            Random rnd3 = new Random();
            skin = skiny[rnd.Next(skiny.Length)];
            typnoza = typynoza[rnd2.Next(typynoza.Length)];
            noza = skin+" "+ typnoza;
            
            return noza;
        }
    }
}
