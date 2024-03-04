using Programa;
using System;
using static System.Collections.Specialized.BitVector32;
namespace Program
{
    public class Program 
    {
    public static void Main()
        {

        Game game = new Game();
            do
            {
                game.ActiveGame = Game.IntToBoolTransformer(game.Selector(1));
                if (game.ActiveGame)
                {
                    Animal animal = Game.AnimalGenerator();
                    Player player = new Player();
                    Rescue rescue = new Rescue();
                    Rescue.GetInfo(player.Name, rescue.NumberOfRescue, rescue.RescueDate, animal.Specie, animal.AfflictionRate, animal.Localization);
                    Animal.GetInfo(animal.Name, animal.Superfamily, animal.Specie, animal.Weight);
                    if (animal.Weight== 0.5)
                    {
                        rescue.RescueType = SeaBird.Selector(animal.AfflictionRate);
                    }
                    else if (animal.Weight== 7)
                    {
                        rescue.RescueType = SeaTurtle.Selector(animal.AfflictionRate);
                    }
                    else
                    {
                        rescue.RescueType = Cetacean.Selector(animal.AfflictionRate);
                    }
                    animal.AfflictionRate = animal.RescueCalculations(animal.AfflictionRate, rescue.RescueType);
                    rescue.RescueResult(animal.AfflictionRate, rescue.RescueType);
                    player.Experience += player.ExperienceUpdater(animal.AfflictionRate, rescue.RescueType);
                }
                else { game.GameLoop = false; }
            } while (game.GameLoop);
        }
    }
}
