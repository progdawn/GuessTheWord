using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheWord
{
    class Controller
    {
        public Controller()
        {
            
        }

        Player userPlayer = new Player();
        Input userInput = new Input();
        Output screenOutput = new Output();
        WordTracker words = new WordTracker();

        //main game loop
        public void MainGame()
        {
            //do this while the user wants to play
            do
            {
                words.PickAWord(); //computer picks a word
                words.FillWithLetters(); //fills an array with chars from that word
                words.FillWithBlanks(); //fills a separate array (containing user's letters) with blanks to print
                screenOutput.Header(userPlayer.TurnsLeft); //tracks turns left
                screenOutput.LettersGuessedHeader(userPlayer.LettersSoFar); //prints letters guessed so far (obviously none)
                screenOutput.GuessingTheWord(words.ChosenWordGuess); //prints blanks 

                //do this while user still has turns, and the user has not won
                do
                {
                    userPlayer.LetterGuessed = userInput.GetALetter(); //gets a letter from the user
                    userPlayer.LettersSoFar += userPlayer.LetterGuessed; //adds that letter to a string to track letters guessed
                    screenOutput.LettersGuessedHeader(userPlayer.LettersSoFar); //puts that same string into a header to track the letters guessed
                    userPlayer.GuessedCorrect = words.FillWithGuesses(userPlayer.LetterGuessed); //cycles through array with player's guess. If they guessed right, flag as true
                    screenOutput.GuessingTheWord(words.ChosenWordGuess); //prints blanks and correctly guessed letters
                    userPlayer.GetTurnsLeft(); //if that same flag is false, deducts a turn from player
                    screenOutput.GuessedRightOrWrong(userPlayer.GuessedCorrect); //tells user if they guessed right or wrong
                    screenOutput.Header(userPlayer.TurnsLeft); //updates header with turns left
                    userPlayer.UserWon = words.PlayerWon(); //cycles through user guesses and actual word. If all letters match, flag as true
                } while (userPlayer.TurnsLeft > 0 && userPlayer.UserWon == false);
                screenOutput.FinalReport(userPlayer.UserWon); //prints a report, telling the user if they won or lost
                userPlayer.NewGame = userInput.NewGame(); //lets the user play again
                ResetAllTheThings();
            }while (userPlayer.NewGame == true);
        }

        //resets variables in between games. I'll learn how to avoid resetting things. I've read it's a bad programming habit
        public void ResetAllTheThings()
        {
            userPlayer.TurnsLeft = 7;
            userPlayer.GuessedCorrect = false;
            userPlayer.LetterGuessed = 'a';
            userPlayer.LettersSoFar = "a";
            userPlayer.UserWon = false;
        }
    }
}
