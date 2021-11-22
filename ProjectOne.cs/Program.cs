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
           

            StreamReader readingSize = new StreamReader("file1.txt");
            int j = 0;
            while(readingSize.ReadLine()!= null)
            {
                j++;
            }
            readingSize.Close();



            Random random = new Random();
            string[] randomWord = new string[j];

            StreamReader reading = new StreamReader("file1.txt");

            for (int i = 0; i < 10; i++)
            {
                randomWord[i] = reading.ReadLine(); 
            }
            reading.Close();

  
            
            while (runGame == true)
            {
                int n = random.Next(j);
                Console.WriteLine("\t\twould you like to play a game \n\t\tyes or no:\t");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "no")
                {
                    break;
                }
                else if (answer.ToLower() == "yes")
                {
                    
                    // move random numbers here so string changes when you start new game.
                    Game game1 = new Game(lives, randomWord[n]);
                    Game.PlayGame(lives, randomWord[n]);

                }


            }





        }

    }
}
// NEED TO DO: 1) create and implament Getting started method  >>>>>  2) move Random() num so string changes when new game begins >>>>>>
// >>>>>>>>> 3) desperatly need to make the visual elements look nice  >>>>>> 4) need to add function when user inputs more than 1 char to restart pick a number.
// >>>>>>> 5) also function needs to make sure the char input is a letter not num or other (&*%^$#). num guess = 0 causes error if you gaues first case corectly 
// >>>>>>> 6) since time will most lickely allow add a player class that holds player data. 
