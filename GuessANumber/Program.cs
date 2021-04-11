using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            #region So it looks a little cleaner.
            Console.Title = "Guess a Number!";
            Console.SetWindowSize(40, 40);
            Random r = new Random();
            int winningNum = r.Next(0, 100);
            bool win = false;
            #endregion

            do
            {
                Console.Write("Guess a number between 0 and 100: ");
                string s = Console.ReadLine();

                int i = int.Parse(s); // parses user input to an int

                if (i > winningNum)
                {
                    Console.WriteLine("Too high!! Guess lower.");                   
                }
                else if (i < winningNum)
                {
                    Console.WriteLine("Too low... Guess higher!");
                }
                else if (i == winningNum)
                {
                    Console.WriteLine("YOU WIN!");
                    win = true;
                }
            } while (!win);
        }
    }
}
