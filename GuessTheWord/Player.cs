using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheWord
{
    class Player
    {
        public Player()
        {

        }

        private int turnsLeft = 7;
        private int turnDeducted = 1;
        private char letterGuessed = ' ';
        private string lettersSoFar = " ";
        private bool guessedCorrect = false;
        private bool userWon = false;
        private bool newGame = true;

        //deducts turn from player if they guessed wrong
        public void GetTurnsLeft()
        {
            if (guessedCorrect == false)
            {   
                turnsLeft -= turnDeducted;
            }
        }

        public int TurnsLeft
        {
            get { return turnsLeft; }
            set { turnsLeft = value; }
        }

        public char LetterGuessed
        {
            get { return letterGuessed; }
            set { letterGuessed = value; }
        }

        public bool GuessedCorrect
        {
            get { return guessedCorrect; }
            set { guessedCorrect = value; }
        }

        public bool UserWon
        {
            get { return userWon; }
            set { userWon = value; }
        }

        public bool NewGame
        {
            get { return newGame; }
            set { newGame = value; }
        }

        public string LettersSoFar
        {
            get { return lettersSoFar; }
            set { lettersSoFar = value; }
        }
    }
}
