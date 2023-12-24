using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjurparkenWinForms
{
    // Subklass för bäver
    class Beaver : animal
    {
        public Beaver(int _Age, string _Name) : base(_Age, _Name)
        {
            Favourite_food = "Bark";
        }

        public override void FeedAnimal(string food)
        {

            int resultat = GetRandomNumber();
            PrintRandomResult(resultat);

            if (resultat == 1)
            {
                if (food == Favourite_food)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"\n{Name} simmar omkring och plaskar med sin svans medans han tuggar i sig lite {Favourite_food}");
                }
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"\n{Name} är hungrig så han simmar ut från sin bäverdamm för att leta upp lite mat..");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        public override void interact(bool throwBall)
        {
            base.interact(throwBall);
        }

    }
}
