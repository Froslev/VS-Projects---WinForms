using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjurparkenWinForms
{
    // Lejon subklass för animal

    class Lion : animal
    {

        // Konstruktor för lejon som anropar basklassens konstruktor och sätter favoritmat
        public Lion(int _Age, string _Name) : base(_Age, _Name)
        {
            Favourite_food = "Kött";
        }

        public override void FeedAnimal(string food)
        {
            int resultat = GetRandomNumber();
            PrintRandomResult(resultat);

            if (resultat == 1)
            {
                Hungry = false;


                if (food == Favourite_food)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"\n{Name} tuggar glatt i sig " + Favourite_food + " och är nöjd..");
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"\n{Name} är hungrig och ute på jakt medans han drömmer om " + Favourite_food + "..");
                Hungry = true;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        // Överlagrad interact metod för lejon som tar emot en bool variabel
        public override void interact(bool throwBall)
        {
            base.interact(throwBall);
        }

    }
}
