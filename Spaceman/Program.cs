using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceman
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game(); // create new object g
            g.Greet(); // call the Greet() method

            do
            {
                g.Display();
                g.Ask();
                if (g.DidLose())
                {
                    g.Display();
                    Console.WriteLine("Oh no! The UFO just flew away with another person!");
                    break;
                }
                else if (g.DidWin())
                {
                    g.Display();
                    Console.WriteLine("Hooray! You saved the person and earned a medal of honor!");
                    break;
                } // else..if
            } while (true); // end while

        } // end Main
    } // end class Programe
} // end namespace Spaceman
