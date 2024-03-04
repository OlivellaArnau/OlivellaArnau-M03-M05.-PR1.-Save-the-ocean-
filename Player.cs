using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Security.Cryptography.X509Certificates;
namespace Programa
{
    public class Player : ISelector
    {
        public static string AskJobMsg = "Perfecte Què vols ser \n1. Tècnic (45 XP)\n2. Veterinari (80 XP)";
        public static string AskNameMsg = "Genial! I el teu nom?";
        private const string ErrorMsg = "Valor Incorrecte, introdueix els valors '1' o '2'.";
        public int Job { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public Player() 
        {
            Job = Selector(1);
            Name = NameSetter("");
            Experience = 0;

        }
        public int Selector(int selection)
        {
            Console.WriteLine(AskJobMsg);
            selection = Convert.ToInt32(Console.ReadLine());
            if (selection == 1 || selection == 2)
                return selection;
            else
            Console.Clear();
            Console.WriteLine(ErrorMsg);
            selection = Selector(selection);
            return selection;
        }
        public static string NameSetter(string name)
        {
            Console.WriteLine(AskNameMsg);
            name = Console.ReadLine();
            return name;
        }
        public int ExperienceUpdater(int NewGA, int RescueType)
        {
            int NewExperience;
            if (NewGA <= 5) { NewExperience= 50; }
            else { NewExperience= -20;}
            if (RescueType == 1){ NewExperience += 45; }
            else { NewExperience += 80;}
            return NewExperience;
        }
    }
}
