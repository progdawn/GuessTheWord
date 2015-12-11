using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheWord
{
    class GuessTheWordApp
    {
        static void Main(string[] args)
        {
            Controller game = new Controller();
            Admin wizardry = new Admin();

            wizardry.ConsoleSetup(); //set window properties
            wizardry.Intro(); //intro to game
            game.MainGame(); //main game loop
            wizardry.Goodbye(); //exit screen
        }
    }
}
