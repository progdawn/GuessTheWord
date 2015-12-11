using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheWord
{
    class Input
    {
        public Input()
        {

        }

        //gets a letter from the user
        public char GetALetter()
        {
            string letterString = "a";
            char letter = 'a';
            Console.SetCursorPosition(0, 6);
            Console.Write("Guess a letter >> ");
            letterString = Console.ReadLine(); //did it this way, because if I did Console.ReadKey().KeyChar, then it messes with user feedback. Probably a better way to do this. 
            letter = char.Parse(letterString);
            Console.WriteLine();
            return letter;
        }

        //ask player if they want to play again
        public bool NewGame()
        {
            string newGameString = "n";
            bool newGameFlag = true;

            Console.SetCursorPosition(0, 10);
            Console.Write("Do you want to play again? (Y / N) ");
            newGameString = Console.ReadLine();
            if (newGameString == "N" || newGameString == "n")
            {
                newGameFlag = false;
            }
            Console.Clear();
            return newGameFlag;
        }
    }
}
