using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheWord
{
    class WordTracker
    {
        Random getAWord = new Random(Guid.NewGuid().GetHashCode());

        private string[] theWords = { "banana", "thunder", "fingernails", "octopus", "heartburn", "environment", "distracted", "chuckle", "cheesehead", "outlet" };
        //this is a great example of bad programming lol. Since the variable length is initialize on compile, or something like that, 
        //and I didn't have enough time to figure out the RIGHT way to do this, I just set thisWord to a long length, longer than any of my available words.
        //So now I'm not getting exceptions due to array length. I KNOW IT'S BAD FEEL FREE TO SCOLD ME!
        private static string thisWord = "asdfasdfasdfasdf"; 
        private char[] chosenWordChars = new char[thisWord.Length];
        private char[] chosenWordGuess = new char[ThisWord.Length];

        //picks a random word from theWords array
        public void PickAWord()
        {
            int chosenWordNum = 0;

            chosenWordNum = getAWord.Next(0, theWords.Length);
            thisWord = theWords[chosenWordNum];
        }

        //fills in the "guesses" array with blanks
        public void FillWithBlanks()
        {
            for (int count = 0; count < thisWord.Length; count++)
            {
                chosenWordGuess[count] = '_';
            }
        }

        //fills choseWordChars array with characters from the chosen word
        public void FillWithLetters()
        {
            chosenWordChars = thisWord.ToCharArray();
        }

        //checks to see if user guessed right. If so, fills the "blank" with the letter
        //also returns a flag for the user guessing right
        public bool FillWithGuesses(char guess)
        {
            bool userGuess = false;

            for (int count = 0; count < chosenWordChars.Length; count++)
            {
                if (guess == chosenWordChars[count])
                {
                    chosenWordGuess[count] = guess;
                    userGuess = true;
                }
            }

            return userGuess;
        }
        
        //cycles through with each guess to see if the user finished guessing the word
        public bool PlayerWon()
        {
            bool userWonFlag = true;
            int count = 0;

            while (userWonFlag == true && count < thisWord.Length)
            {
                if (chosenWordChars[count] == chosenWordGuess[count])
                {
                    userWonFlag = true;
                }
                else
                {
                    userWonFlag = false;
                }
                count++;
            }
            return userWonFlag;
        }

        public char[] ChosenWordGuess
        {
            get { return chosenWordGuess; }
            set { chosenWordGuess = value; }
        }

        public string[] TheWords
        {
            get { return theWords; }
        }

        public static string ThisWord
        {
            get { return thisWord; }
            set { thisWord = value; }
        }
    }
}
