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

            // reads each line to gather amount of words there are
            StreamReader readingSize = new StreamReader("file1.txt"); 
            int j = 0;
            while(readingSize.ReadLine()!= null)
            {
                j++;
            }
            readingSize.Close();



            Random random = new Random();// initializing random 
            string[] randomWord = new string[j]; // initailizing array

            // inputing each word from text file into array 
            StreamReader reading = new StreamReader("file1.txt");
            for (int i = 0; i < j; i++)
            {
                randomWord[i] = reading.ReadLine(); 
            }
            reading.Close();

  
            
            while (runGame == true)
            {
                int n = random.Next(j); // uses amount of words gathered to determine next random

                // console output/input for playing game
                Console.WriteLine("\t\twould you like to play a game \n\t\tyes or no:\t");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "no")
                {
                    break;
                }
                else if (answer.ToLower() == "yes")
                {
                    string hidden = randomWord[n];
                    // sends data to PlayGame method in Game 
                    Game g = new Game(3, hidden);
                   
                    g.PlayGame(g);

                }
                


            }





        }

    }
}

