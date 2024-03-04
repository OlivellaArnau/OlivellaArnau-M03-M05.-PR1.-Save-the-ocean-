using Program;
using System;
using System.Runtime.CompilerServices;
namespace Programa
{
    public class Game : ISelector
    {
        private const string SaveTheOceanMsg = "Save The Ocean!";
        private const string AskMsg = "Que vols fer?";
        private const string StartGameMsg = "1- Jugar";
        private const string QuitGameMsg = "2- Sortir";
        private const string ErrorMsg = "Valor Incorrecte, introdueix els valors '1' o '2'.";
        public bool ActiveGame { get; set; }
        public bool GameLoop { get; set; }
        //Constructor Inici//
        public Game() 
        {
            GameLoop = true;
            ActiveGame = true;
        }
        //Comportament per transformar les seleccions del jugador en booleans//
        public static bool IntToBoolTransformer(int selection)
        {
            if (selection == 1) return true;
            return false;
        }
        //Comportament per demanar opcio d'inici entrar al joc o sortir//
        public int Selector(int selector)
        {
            Console.WriteLine(SaveTheOceanMsg);
            Console.WriteLine($"{AskMsg}\n{StartGameMsg}\n{QuitGameMsg}");
            selector = Convert.ToInt32(Console.ReadLine());
            if (selector == 1 || selector == 2) { return selector; }
            else
            {
                Console.Clear();
                Console.WriteLine(ErrorMsg);
                Selector(selector);
                return selector;
            }
        }
        //Generador d'animals//
        public static Animal AnimalGenerator()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            switch (randomNumber)
            {
                case 0:
                    return new Cetacean();
                case 1:
                    return new SeaBird();
                case 2:
                    return new SeaTurtle();
                default:
                    return new Cetacean();
            }
        }
    }
}
