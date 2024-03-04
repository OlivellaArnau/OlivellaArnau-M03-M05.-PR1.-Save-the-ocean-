using Programa;
using System;
namespace Program
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Superfamily { get; set; }
        public string Specie { get; set; }
        public double Weight { get; set; }
        public int AfflictionRate {  get; set; }
        public string Localization { get; set; }
        //Constructor Base//
        public Animal() 
        {
            Name = "";
            Superfamily = "";
            Specie = "";
            Weight = 0;
            AfflictionRate = AfflictionRateCalc();
            Localization = "";
        }
        //Clase Abstracta per calcular GA//
        public abstract int RescueCalculations(int GA, int selection);
        //Generador d'Aflicció//
        public static int AfflictionRateCalc()
        {
            Random random = new Random();
            return random.Next(1, 100);
        }
        //Taula Animals//
        public static void GetInfo(string Name, string Superfamily, string Specie, double Weight)
        {
            Console.WriteLine("Aquí tens la seva fitxa, per a més informació:");
            Console.WriteLine($"+-------------------------------------------------------------+\r\n|                       FITXA                                 |\r\n+-------------------------------------------------------------+\r\n| # Nom | Superfamília | Espècie        | Pes aproximat       |\r\n+-------------------------------------------------------------+\r\n| {Name} | {Superfamily}  | {Specie} | {Weight}kg            |\r\n+-------------------------------------------------------------+\r\n");
        }
    }
}
