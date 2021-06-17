using System;
using System.Linq;
using System.Globalization;
using TabloidCLI.UserInterfaceManagers;
using System.Threading;

namespace TabloidCLI
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter desired background color for this screen. ");
            Console.WriteLine();
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine($"{i + 1}) {colors[i]}");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("(This program will assign a legible text color based on your choice) ");
            Console.WriteLine();
            Console.Write("> ");
            string bg = Console.ReadLine();
            try
            {
                int pick = (int.Parse(bg) - 1);
                Console.BackgroundColor = colors[pick];
                if (pick > 9)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if (pick == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("I don't understand what you typed! Type a valid number");
            }
            Thread.Sleep(250);
            Console.WriteLine("You have such a nice aura today!");
            Console.WriteLine("");
            
            // MainMenuManager implements the IUserInterfaceManager interface
            IUserInterfaceManager ui = new MainMenuManager();
            while (ui != null)
            {
                // Each call to Execute will return the next IUserInterfaceManager we should execute
                // When it returns null, we should exit the program;
                ui = ui.Execute();
            }
        }
    }
}
