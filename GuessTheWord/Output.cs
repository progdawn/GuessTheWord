using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheWord
{
    class Output
    {
        public Output()
        {

        }

        Sounds sweetTunes = new Sounds();
        Admin windowSize = new Admin();

        //prints array of blanks and guesses
        public void GuessingTheWord(char[] guesses)
        {
            Console.SetCursorPosition(0, 4);
            Console.WriteLine(string.Join("  ", guesses));
        }

        //tells the user if they guessed right or wrong
        public void GuessedRightOrWrong(bool correct)
        {
            Console.SetCursorPosition(0, 8);
            if (correct == true)
            {
                sweetTunes.UserGuessRight();
                Console.WriteLine("You guessed right!");
            }
            else
            {
                sweetTunes.UserGuessedWrong();
                Console.WriteLine("You guessed wrong!");
            }
        }

        //tells the user if they won or loss
        public void FinalReport(bool playerWonFlag)
        {
            Console.SetCursorPosition(0, 9);
            if (playerWonFlag == true)
            {
                sweetTunes.UserWon();
                Console.WriteLine("Good job! You won!");
            }
            else
            {
                sweetTunes.UserLoss();
                Console.WriteLine("You ran out of turns!");
            }
        }

        //headers for tracking turns left
        public void Header(int turnsLeft)
        {
            ConsoleColor originalBg = Console.BackgroundColor;
            ConsoleColor originalText = Console.ForegroundColor;
            int left = Console.CursorLeft;
            int top = Console.CursorTop;
            Console.SetCursorPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Turns left: {0}", turnsLeft);
            int restOfLine = Console.CursorLeft;
            for(int fill = restOfLine; fill < windowSize.WindowWidth; fill++)
            {
                Console.Write(" ");
            }
            Console.BackgroundColor = originalBg;
            Console.ForegroundColor = originalText;
            Console.SetCursorPosition(left, top);
        }

        //header for tracking letters guessed
        public void LettersGuessedHeader(string letters)
        {
            ConsoleColor originalBg = Console.BackgroundColor;
            ConsoleColor originalText = Console.ForegroundColor;
            int left = Console.CursorLeft;
            int top = Console.CursorTop;
            Console.SetCursorPosition(0, 1);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Letters guessed: {0}", letters);
                        int restOfLine = Console.CursorLeft;
            for(int fill = restOfLine; fill < windowSize.WindowWidth; fill++)
            {
                Console.Write(" ");
            }
            Console.BackgroundColor = originalBg;
            Console.ForegroundColor = originalText;
            Console.SetCursorPosition(left, top);
        }
    }
}
