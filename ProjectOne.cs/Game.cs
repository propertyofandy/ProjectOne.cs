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
        
        public Game(int lives, string hidden)
        {
            lives = this.lives;
            hidden = this.hidden;
           
        }

        public static bool PlayGame( int lives, string hidden)
        {
            lives = 3; 
            int numGeuss = 0;
            string[] secret = new string[hidden.Length];
            
            bool gameWon = false;
            LetterSpots(hidden, secret, numGeuss);
            GettingStarted();
            while (gameWon == false)
            {
                string lifeCheck = "";
                for (int i = 0; i < hidden.Length; i++)
                {
                    lifeCheck = lifeCheck + secret[i];
                }
                string lifeCheck2 = lifeCheck;
                numGeuss = 1;
                
                secret = GuessChecker(hidden, secret);
                LetterSpots(hidden, secret, numGeuss);

                lifeCheck = "";
                for (int i = 0; i < hidden.Length; i++)
                {
                    lifeCheck = lifeCheck + secret[i];
                }

                if(lifeCheck == lifeCheck2)
                {
                    lives--;
                    Console.WriteLine($"you have {lives} remaining");
                
                }

                if (DidYaWin(hidden, secret) == true)
                {
                    gameWon = true;
                }

                if(lives == 0)
                {
                    Console.WriteLine("game over");
                    gameWon = true;
                }
                numGeuss++;
            }
            if (lives != 0)
            {
                Console.WriteLine("you won");
            }

            return true;


        }

        public static bool DidYaWin(string hidden,string[] secret)
        {
            
            string checking = "";
            for (int i = 0; i < hidden.Length; i++)
            {

                checking = checking + secret[i];

            }

            if (checking == hidden)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        public static void LetterSpots(string hidden, string[] secret, int numGuess)
        {
          
            if (numGuess == 0) // if num guess == 0 then do this <<<<<<<<
            {
                Console.Write("\t\t");
                for (int i = 0; i < hidden.Length; i++)
                {
                    secret[i] = "_"; 
                    Console.Write(secret[i]+" ");
                }
            }
            else
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

            if (guess.Length != 1)
            {
                Console.WriteLine("guess a letter meaning one");
                GuessChecker(hidden, secret);
            }

            if (guess[0] >= 'a' && guess[0] <= 'z' || guess[0] >= 'A' && guess[0] <= 'Z')
            {

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
            else
            {
                Console.WriteLine("are you sure you now what letters are?");
                    GuessChecker(hidden, secret);
             }
            
            
            return secret;


        }
        public static void GettingStarted()
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
