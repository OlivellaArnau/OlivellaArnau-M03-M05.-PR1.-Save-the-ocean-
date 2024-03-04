using Programa;
using System;
namespace Program
{
    public class Rescue
    {
        public string NumberOfRescue {  get; set; }
        public string RescueDate {  get; set; }
        public int RescueType { get; set; }
        public Rescue() 
        {
            NumberOfRescue = RandomRescueNumGen();
            RescueDate = Date();
            RescueType = 1;
        }
        public static string RandomRescueNumGen() 
        {
        Random random = new Random();
        int randomNum = random.Next(0, 100);
        return $"RES{randomNum.ToString("D3")}";
        }
        public static string Date()
        {
            DateTime currentDate = DateTime.Now;
            int year = currentDate.Year;
            int month = currentDate.Month;
            int day = currentDate.Day;
            return $"{day}/{month}/{year}";
        }
        public static void GetInfo(string name, string ResNum, string RDate, string specie, int GA, string Localization) 
        {
            Console.WriteLine($"\"Hola, {name}! El 112 ha rebut una trucada d’avís d’un exemplar a rescatar.\nLes dades que ens han donat són les següents:\"");
            Console.WriteLine();
            Console.WriteLine($"+-------------------------------------------------------------+\r\n|                       RESCAT                                |\r\n+-------------------------------------------------------------+\r\n| # Rescat | Data rescat | Superfamília   | GA | Localització |\r\n+-------------------------------------------------------------+\r\n| {ResNum}   | {RDate}  | {specie}         | {GA} | {Localization}     |\r\n+-------------------------------------------------------------+\r\n");
        }
        public void RescueResult(int affliction, int rescueType)
        {
            Console.WriteLine($"El tractament aplicat ha reduït el GA fins al {affliction}%.");
            if (rescueType == 2)
            {
                if (affliction > 5)
                {
                    Console.Write("Ha mort de camí al centre.La teva experiència s’ha reduït en - 20XP.");
                }
                if (affliction <= 5)
                {
                    Console.Write("L’exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en + 50XP.");
                }
            }
            if (rescueType == 1)
            {
                if (affliction > 5)
                {
                    Console.Write("No ha estat prou efectiu i cal traslladar l’exemplar al centre.La teva experiència s’ha reduït en - 20XP.");
                }
                if (affliction <= 5)
                {
                    Console.Write("L’exemplar està recuperat. La teva experiència ha augmentat en + 50XP.");
                }
                Console.WriteLine("");
                Console.WriteLine("Fins el proper rescat!")
            }
        }
    }
}
