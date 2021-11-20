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

        public static bool PlayGame(int lives, string hidden)
        {
            int numGeuss = 0;
            string[] secret = new string[hidden.Length];
            bool gameWon = false;
            LetterSpots(hidden, secret, numGeuss);
            while (gameWon == false)
            {
                
                Console.Write("guess a letter");
                string guess = Console.ReadLine();
                Console.WriteLine(guess);
                secret = GuessChecker(guess,hidden, secret);
                LetterSpots(hidden, secret, numGeuss);
                if (DidYaWin(hidden, secret) == true)
                {
                    gameWon = true;
                }


                numGeuss++;
            }


            return true;


        }

        public static bool DidYaWin(string hidden,string[] secret)
        {
            Console.Write("secrete == " + secret[0]);
            string checking = "";
            for (int i = 0; i < hidden.Length; i++)
            {
                //string p = secret[0]; 
                
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
                    secret[i] = "_ "; 
                    Console.Write("_ ");
                }
            }
            else
            {
                Console.Write("\t\t");
                for (int j = 0; j < hidden.Length; j++)
                {
                    Console.Write(secret[j] + " ");
                }
            }
            Console.WriteLine();
        }
        
        public  static  string[] GuessChecker(string guess, string hidden, string[] secret) 
        {
            Console.WriteLine(hidden);
            
            for (int i = 0; i < hidden.Length; i++)
            {
                if (guess[0] == hidden[i])
                {
                    secret[i] = guess;
                    
                }
                
                
                
            }
            return secret;


        }
        public void GettingStarted()
        {
            // print what game is, game rules, ect 

        }



    }
    // >=a && <=z <<<<<<<< add later in guesschecker. 
}
