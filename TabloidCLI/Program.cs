using System;
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
            ConsoleColor[] consoleColors
            = (ConsoleColor[])ConsoleColor
                  .GetValues(typeof(ConsoleColor));
            Console.WriteLine("List of available " + "Console Colors:");
            foreach (var color in consoleColors)
            Console.WriteLine(color);
            Console.WriteLine();
            Console.WriteLine("Please capitalize the first letter. ");
            Console.WriteLine();
            Console.Write("> ");
            var screen = Console.ReadLine();
            //var finalScreen = screen.ToString().ToUpper();
            
            //var finalText = text.ToString().ToUpper();
            // Attempt to parse the colors that the user entered into their respective enum values.
            // The new values of background and foreground will be set to the user input
            if (Enum.TryParse(screen, out ConsoleColor background))
            {
                Console.BackgroundColor = background;
            }
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Thread.Sleep(300);
            Console.WriteLine("You have such a nice aura today!");
            Console.WriteLine(" ");
            
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
