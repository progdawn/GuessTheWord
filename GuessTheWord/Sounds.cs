using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheWord
{
    //sounds for the game
    class Sounds
    {
        public Sounds()
        {

        }

        //sound for user guessing right
        public void UserGuessRight()
        {
            Console.Beep(500, 100);
        }

        //sound for user guessing wrong
        public void UserGuessedWrong()
        {
            Console.Beep(300, 100);
        }

        //if user won
        public void UserWon()
        {
            Console.Beep(423, 300);
            Console.Beep(587, 300);
            Console.Beep(361, 300);
            Console.Beep(392, 600);
        }

        //if user loss
        public void UserLoss()
        {
            Console.Beep(423, 300);
            Console.Beep(387, 300);
            Console.Beep(261, 300);
            Console.Beep(192, 600);
        }
    }
}
