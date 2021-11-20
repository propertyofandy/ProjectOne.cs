using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectOne.cs
{
    
    class Program
    {
        

        static void Main(string[] args)
        {
            bool runGame = true;
            int lives = 3;
            string hidden;

            Random random = new Random();
            string[] randomWord = new string[10];

            StreamReader reading = new StreamReader("file1.txt");

            for (int i = 0; i < 10; i++)
            {
                randomWord[i] = reading.ReadLine(); 
            }
            reading.Close();

            int n = random.Next(10);
            Console.WriteLine(n);
            
            while (runGame == true)
            {
                Console.WriteLine("would you like to play a game");

                if (Console.ReadLine() == "n")
                {
                    break;
                }

                // move random numbers here so string changes when you start new game.
                Game game1 = new Game(lives, randomWord[n]);
                if(Game.PlayGame(lives, randomWord[n])== true)
                {
                    Console.WriteLine("you won");
                }
              
                


            }





        }

    }
}
// NEED TO DO: 1) create and implament Getting started method  >>>>>  2) move Random() num so string changes when new game begins >>>>>>
// >>>>>>>>> 3) desperatly need to make the visual elements look nice  >>>>>> 4) need to add function when user inputs more than 1 char to restart pick a number.
// >>>>>>> 5) also function needs to make sure the char input is a letter not num or other (&*%^$#). num guess = 0 causes error if you gaues first case corectly 
// >>>>>>> 6) since time will most lickely allow add a player class that holds player data. 
