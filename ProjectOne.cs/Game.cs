using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.cs
{
    class Game
    {
        public int lives;
        public string hidden;

        public Game()
        {
            lives = 3;
            hidden = "hello";

        }

        public Game(int lives, string hidden)
        {
            this.lives = lives;
            this.hidden = hidden;

        }

        public void PlayGame( Game g)
        {
            int numGeuss = 0; // number of guesses will use later
            string[] secret = new string[hidden.Length]; // creating array with elements = length of hidden
            
            bool gameWon = false;
            LetterSpots(hidden, secret, numGeuss);// places _ or corect guess in array
            GettingStarted();
            while (gameWon == false) // play game while false
            {
                // creates string from secret[] will be used later to check lives
                string lifeCheck = "";
                for (int i = 0; i < hidden.Length; i++)
                {
                    lifeCheck = lifeCheck + secret[i];
                }
                string lifeCheck2 = lifeCheck; // we now assign the values to lifecheck2
                numGeuss = 1;
                
                secret = GuessChecker(hidden, secret); 
                LetterSpots(hidden, secret, numGeuss);

                // we now set lifecheck = secret[i]
                lifeCheck = "";
                for (int i = 0; i < hidden.Length; i++)
                {
                    lifeCheck = lifeCheck + secret[i];
                }

                if(lifeCheck == lifeCheck2) // if both values are the same then you lost a life
                {
                    lives--;
                    Console.WriteLine($"you have {lives} remaining");
                
                }

                if (DidYaWin(hidden, secret) == true)
                {
                    gameWon = true;
                }

                if(lives == 0) // check if you lost 
                {
                    Console.WriteLine("game over the word was " + hidden);
                    gameWon = true;
                }
                numGeuss++;
            }
            if (lives != 0) // check if you won
            {
                Console.WriteLine("you won");
            }

         


        }

        public static bool DidYaWin(string hidden,string[] secret)
        {
            
            string checking = ""; 
            for (int i = 0; i < hidden.Length; i++) // turns array into a string called checking
            {

                checking = checking + secret[i];

            }

            if (checking == hidden) // if matches return true you won
            {
                return true;
            }

            else // otherwise you did not win yet
            {
                return false;
            }

        }

        public static void LetterSpots(string hidden, string[] secret, int numGuess)
        {
          
            if (numGuess == 0) // the first instances inputs _ array and prints during first instance
            {
                Console.Write("\t\t");
                for (int i = 0; i < hidden.Length; i++)
                {
                    secret[i] = "_"; 
                    Console.Write(secret[i]+" ");
                }
            }
            else // if not first instance prints each element of the array
            {
                Console.WriteLine("\t\t");
                for (int j = 0; j < hidden.Length; j++)
                {
                    Console.Write(secret[j] + " ");
                }
            }
            Console.WriteLine();
           
        }
        
        public  static  string[] GuessChecker(string hidden, string[] secret) 
        {
            
            Console.Write("\t\tguess a letter:\t");
            string guess = Console.ReadLine();
            Console.WriteLine(guess);

            while (guess.Length != 1)// checks if the gues is a single letter if not try again
            {
                Console.Write("\t\tguess a letter:\t");
                guess = Console.ReadLine();
                Console.WriteLine(guess);
                Console.WriteLine("guess a letter meaning one");
                
            }
            // checks if char is alphabetical
            if (guess[0] >= 'a' && guess[0] <= 'z' || guess[0] >= 'A' && guess[0] <= 'Z')
            {
                // if so put guess value into correct spot in array 
                for (int i = 0; i < hidden.Length; i++)
                {
                        int wrongGuess = 0;
                        if (guess[0] == hidden[i])
                        {
                            secret[i] = guess;
                            wrongGuess++;

                        }
                }
            }
            else //otherwise recall method
            {
                Console.WriteLine("are you sure you now what letters are?");
                    GuessChecker(hidden, secret);
             }
            
            
            return secret;


        }
        public static void GettingStarted() // souly to display game rules at the start of game. 
        {
            Console.WriteLine("\n");
            Console.WriteLine("the game we are going to play is called \"Guess the String\"");
            Console.WriteLine("and no it is not hang man... the rules are");
            Console.WriteLine("guess a letter if you guess right you will be shown a clue");
            Console.WriteLine("guess incorectly and you will be eliminated");
            Console.WriteLine("Ps. you already agreed to play and are legally obligated to continue.\n");

        }

    }

}
