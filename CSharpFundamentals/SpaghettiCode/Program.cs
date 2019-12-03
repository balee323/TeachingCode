using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaghettiCode
{
    class Program
    {
        static void Main(string[] args)
        {


            string mainCharacterName = "";
            string mainCharacterSuperPower = "";
            int mainCharacterPowerLevel = 0;
            int mainCharacterFightsWon = 0;

            string villiansName = "";
            string villainsSuperPower = "";
            int villainsPowerLevel = 0;
            int villiansFighsWon = 0;

            Console.WriteLine("!!!!  SUPER HERO FIGHT GAME  !!!.");


            Console.WriteLine("Press enter your name.");
            mainCharacterName = Console.ReadLine();


            Console.WriteLine("Press enter your super power.");
            mainCharacterSuperPower = Console.ReadLine();


            Console.WriteLine("Press enter a villian's name.");
            villiansName = Console.ReadLine();

            Console.WriteLine("Press enter villian's super power.");
            villainsSuperPower = Console.ReadLine();


            //let's randomly find the main character's power level
            Random rand1 = new Random(DateTime.Now.Millisecond);
            mainCharacterPowerLevel = rand1.Next(1, 20);


            //let's randomly find the villian's power level
            Random rand2 = new Random(DateTime.Now.Millisecond);
            villainsPowerLevel = rand1.Next(1, 20);


            
            //first fight
            if(mainCharacterPowerLevel > villainsPowerLevel)
            {
                mainCharacterFightsWon = mainCharacterFightsWon + 1;
            }
            else
            {
                villiansFighsWon = villiansFighsWon + 1;
            }

            //let's randomly find the main character's power level
            mainCharacterPowerLevel = rand1.Next(1, 20);


            //let's randomly find the villian's power level
            villainsPowerLevel = rand1.Next(1, 20);


            //second fight
            if (mainCharacterPowerLevel > villainsPowerLevel)
            {
                mainCharacterFightsWon = mainCharacterFightsWon + 1;
            }
            else
            {
                villiansFighsWon = villiansFighsWon + 1;
            }

            //let's randomly find the main character's power level
            mainCharacterPowerLevel = rand1.Next(1, 20);


            //let's randomly find the villian's power level
            villainsPowerLevel = rand1.Next(1, 20);


            //third fight
            if (mainCharacterPowerLevel > villainsPowerLevel)
            {
                mainCharacterFightsWon = mainCharacterFightsWon + 1;
            }
            else
            {
                villiansFighsWon = villiansFighsWon + 1;
            }


            //final results
            if (mainCharacterFightsWon > villiansFighsWon)
            {
                Console.WriteLine($"You won the fight! Your super power was {mainCharacterSuperPower}.");
            }
            else
            {
                Console.WriteLine($"You lost the fight! {villiansName} had defeated you with their {mainCharacterSuperPower}.");
            }



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}
