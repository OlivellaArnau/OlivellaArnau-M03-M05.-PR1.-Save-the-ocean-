using Program;
using System;
using System.Xml.Linq;
namespace Programa
{
    internal class Cetacean : Animal
    {
        private const string ErrorMsg = "Valor Incorrecte, introdueix els valors '1' o '2'.";
        //Constructor//
        public Cetacean() : base()
        {
            Name = "Sami ";
            Superfamily = "Cetaci     ";
            Specie = "Dofí llisat   ";
            Weight = 20.5;
            AfflictionRate = Animal.AfflictionRateCalc();
            Localization = "Cadaquès";
        }
        public override int RescueCalculations(int affliction, int selection)
        {
            if (selection == 1) { selection = 25; }
            else if (selection == 2) { selection = 0; }
            int NewAffliction = affliction - (int)Math.Floor(Math.Log10(affliction))-selection;
            return NewAffliction;
        }
        public static int Selector(int afflctionRate)
        {

            Console.WriteLine($"El cetaci té un grau d’afectació (GA) del {afflctionRate}%. Vols curar-la (1) o traslladar-la al centre (2)?");
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
