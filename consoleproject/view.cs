using System;
using System.Threading;

namespace consoleproject
{
    public class mainSet
    {
        public void textView()
        {
            int windowWidth = 130; // Example width
            int windowHeight = 60; // Example height

            Console.SetWindowSize(windowWidth, windowHeight);
            Console.SetBufferSize(windowWidth, windowHeight);
            Console.SetWindowSize(110,60);
            Console.SetBufferSize(110,60);

            string[] mainLogo = {
                @"       d8888 8888888b. 88888888888      888       888  .d88888b.  8888888b.  888      8888888b.",
                @"      d88888 888   Y88b    888          888   o   888 d88P"" ""Y88b 888   Y88b 888      888  ""Y88b",
                @"     d88P888 888    888    888          888  d8b  888 888     888 888    888 888      888    888",
                @"    d88P 888 888   d88P    888          888 d888b 888 888     888 888   d88P 888      888    888",
                @"   d88P  888 8888888P""     888          888d88888b888 888     888 8888888P""  888      888    888",
                @"  d88P   888 888 T88b      888          88888P Y88888 888     888 888 T88b   888      888    888",
                @" d8888888888 888  T88b     888          8888P   Y8888 Y88b. .d88P 888  T88b  888      888  .d88P",
                @"d88P     888 888   T88b    888          888P     Y888  ""Y88888P""  888   T88b 88888888 8888888P"""
            };

            int left = (Console.WindowWidth - mainLogo[0].Length) / 2;
            if (left < 0) left = 0; // Ensure left is non-negative

            // Draw the initial border
            DrawBorder();

            for (int i = 0; i < mainLogo.Length; i++)
            {
                Console.SetCursorPosition(left, i + 3); // Start drawing from the top

                // Draw the logo line
                Console.WriteLine(mainLogo[i]);

                Thread.Sleep(50);
            }
        }

        // Method to draw a fixed border around the console window
        private void DrawBorder()
        {
            int windowWidth = Console.WindowWidth;
            int windowHeight = Console.WindowHeight;

            // Draw top border
            Console.SetCursorPosition(0, 0);
            Console.Write("■" + new string('■', windowWidth - 57) + "■");

            // Draw bottom border
            Console.SetCursorPosition(0, windowHeight - 1);
            Console.Write("■" + new string('■', windowWidth - 57) + "■");

            // Draw left and right borders
            for (int i = 1; i < windowHeight - 1; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("■");
                Console.SetCursorPosition(windowWidth -2, i);
                Console.Write("■");
            }
        }
    }
}
