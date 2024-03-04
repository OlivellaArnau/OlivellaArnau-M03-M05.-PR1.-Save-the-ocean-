using Program;
using System;
using System.Xml.Linq;
namespace Programa
{
    public class SeaTurtle : Animal
    {
        private const string ErrorMsg = "Valor Incorrecte, introdueix els valors '1' o '2'.";
        public SeaTurtle() : base()
        {
            Name = "Martín";
            Superfamily = "Tortuga Marina";
            Specie = "Tortuga Careta";
            Weight = 7;
            AfflictionRate = Animal.AfflictionRateCalc();
            Localization = "Gavà";
        }
        public override int RescueCalculations(int affliction, int selection)
        {
            selection = 5;
            int NewAffliction = affliction - ((affliction-2) * (2*affliction+3))-selection;
            return NewAffliction;
        }
        public static int Selector(int afflctionRate)
        {
            Console.WriteLine($"La tortuga té un grau d’afectació (GA) del {afflctionRate}%. Vols curar-la (1) o traslladar-la al centre (2)?");
            int selector = Convert.ToInt32(Console.ReadLine());
            if (selector == 1 || selector == 2) { return selector; }
            else
            {
                Console.Clear();
                Console.WriteLine(ErrorMsg);
                Selector(afflctionRate);
                return selector;
            }
        }
    }
}
