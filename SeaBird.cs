using Program;
using System;
namespace Programa
{
    public class SeaBird : Animal
    {
        private const string ErrorMsg = "Valor Incorrecte, introdueix els valors '1' o '2'.";
        public SeaBird() : base ()
        {
            Name = "Gaspar";
            Superfamily = "Au Marina ";
            Specie = "Pardela       ";
            Weight = 0.5;
            AfflictionRate = Animal.AfflictionRateCalc();
            Localization = "Canet de Mar";

        }
        public override int RescueCalculations(int affliction, int selection)
        {
            if (selection == 1) {selection = 5;} 
            else if (selection == 2) { selection = 0; }
            int NewAffliction = affliction-(affliction*affliction + selection);
            return NewAffliction;
        }
        public static int Selector(int afflctionRate)
        {
            Console.WriteLine($"L'ocell marí té un grau d’afectació (GA) del {afflctionRate}%. Vols curar-la (1) o traslladar-la al centre (2)?");
            int selector = Convert.ToInt32(Console.ReadLine());
            if (selector == 1 || selector == 2) { return selector; }
            else
            {
                Console.Clear();
                Console.WriteLine(ErrorMsg);
                Selector(selector);
                return selector;
            }
        }
    }
}
