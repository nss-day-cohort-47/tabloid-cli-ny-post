using System;
using TabloidCLI.UserInterfaceManagers;

namespace TabloidCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a background color:");
            Console.Write("> ");
            var bg = Console.ReadLine();
            Console.WriteLine("Please enter a text color: ");
            Console.Write("> ");
            var text = Console.ReadLine();
            // Attempt to parse the colors that the user entered into their respective enum values.
            // The new values of background and foreground will be set to the user input
            if (Enum.TryParse(bg, out ConsoleColor background))
            {
                Console.BackgroundColor = background;
            }
            if (Enum.TryParse(text, out ConsoleColor foreground))
            {
                Console.ForegroundColor = foreground;
            }
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
