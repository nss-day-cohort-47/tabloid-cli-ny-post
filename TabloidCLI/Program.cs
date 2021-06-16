using System;
using TabloidCLI.UserInterfaceManagers;

namespace TabloidCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("=====================================");
            //Console.ForegroundColor = ConsoleColor.White;
            //// Let's go through all Console colors and set them as background
            //Console.WriteLine("Choose a background color:");
            //BGColor = Console.ReadLine();
            //Console.BackgroundColor($"{BGColor}");
            //foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            //{
            //    Console.BackgroundColor = color;
            //    Console.WriteLine($"Background color set to {color}");
            //}
         
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
