using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GuessTheWord
{
    //used for setting up the console, providing introduction, and exiting the application
    class Admin
    {
        //default constructor
        public Admin()
        {

        }

        private int windowWidth = 80;
        private int windowHeight = 25;


        //sets up console title, size, and colors
        public void ConsoleSetup()
        {
            Console.Title = "Guess The Word!"; //window title
            Console.SetWindowSize(windowWidth, windowHeight); //window size, makes things easier to read
            Console.BackgroundColor = ConsoleColor.Blue; //background color of console
            Console.ForegroundColor = ConsoleColor.Yellow; //text color
            Console.Clear();
        }

        //introduction and instructions for the application
        public void Intro()
        {
            Console.Beep(330, 500);
            Console.WriteLine("Welcome to Guess The Word!");
            Lazy();
            Console.WriteLine("In this game, the computer will pick a word");
            Lazy();
            Console.WriteLine("You then have to guess the letters of the word.");
            Lazy();
            Console.WriteLine("You'll get 7 lives. If you guess wrong, you lose a life.");
            Lazy();
            Console.WriteLine("If you guess the whole word, you win!");
            Lazy();
            Console.WriteLine("If you run out of lives, you lose.");
            Lazy();
            Console.Write("Press any key to play >> ");
            Console.ReadKey();
            Console.Clear();
        }

        //provides a way to exit the application
        public void Goodbye()
        {
            Console.Clear();
            Console.Beep(330, 200);
            Console.WriteLine("Thanks for playing Guess The Word!");
            Lazy();
            Console.Write("Shutting down");
            Lazy();
            Console.Write(".");
            Lazy();
            Console.Write(".");
            Lazy();
            Console.Write(".");
        }

        public void Lazy()
        {
            Thread.Sleep(500);
        }

        public int WindowWidth
        {
            get { return windowWidth; }
            set { windowWidth = value; }
        }

        public int WindowHeight
        {
            get { return windowHeight; }
            set { windowHeight = value; }
        }
    }
}
