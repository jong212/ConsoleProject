
using System;

class mapmove
{
    static int playerX = 0;
    static int playerY = 0;
    static char[,] currentMap;

    static char[,] map1 = new char[,]
    {
        { '■', ' ', ' ', ' ', '■', ' ', ' ', ' ', ' ', ' ', ' ' },
        { '■', '■', ' ', ' ', ' ', ' ', '■', ' ', '■', ' ', ' ' },
        { '■', ' ', ' ', '■', '■', ' ', ' ', ' ', ' ', '■', ' ' },
        { '■', '■', ' ', ' ', ' ', '■', ' ', ' ', ' ', ' ', ' ' },
        { '■', ' ', ' ', '■', ' ', ' ', ' ', '■', ' ', '■', 'E' }, // E■it at (10, 4)
        // More rows as needed
    };

    static char[,] map2 = new char[,]
    {
        { '■', '■', '■', '■', ' ', '■', '■', '■', '■', '■', '■' },
        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '■' },
        { '■', '■', '■', '■', '■', '■', ' ', '■', '■', ' ', '■' },
        { ' ', ' ', ' ', ' ', ' ', '■', ' ', '■', ' ', ' ', ' ' },
        { '■', '■', '■', '■', '■', '■', ' ', '■', '■', '■', '■' },
        // More rows as needed
    };

    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        currentMap = map1; // Start with map1
        DrawMap();
        DrawPlayer();

        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        MovePlayer(0, -1);
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        MovePlayer(0, 1);
                        break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        MovePlayer(-1, 0);
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        MovePlayer(1, 0);
                        break;
                }

                // Check if player has reached the exit
                CheckForMapTransition();
            }
        }
    }

    static void DrawMap()
    {
        Console.Clear(); // Clear the console before drawing the new map
        for (int y = 0; y < currentMap.GetLength(1); y++)
        {
            for (int x = 0; x < currentMap.GetLength(0); x++)
            {
                Console.Write(currentMap[x, y]);
            }
            Console.WriteLine();
            
        }
    }

    static void DrawPlayer()
    {
        Console.SetCursorPosition(playerX, playerY);
        Console.Write("P");
    }

    static void MovePlayer(int dx, int dy)
    {
        int newX = playerX + dx;
        int newY = playerY + dy;

        // Check map boundaries and obstacles (excluding 'E' to allow standing on it)
        if (newX >= 0 && newX < currentMap.GetLength(0) && newY >= 0 && newY < currentMap.GetLength(1) && (currentMap[newX, newY] == ' ' || currentMap[newX, newY] == 'E'))
        {
            Console.SetCursorPosition(playerX, playerY);
            Console.Write(" "); // Clear the old position

            playerX = newX;
            playerY = newY;

            DrawPlayer();
        }
    }

    static void CheckForMapTransition()
    {
        if (currentMap[playerX, playerY] == 'E') // Player has reached the exit
        {
            if (currentMap == map1)
            {
                currentMap = map2; // Change to map2
                playerX = 0; // Reset player position for the new map
                playerY = 0;
            }
            // Add else if blocks for other maps with exits here if needed
            DrawMap();
            DrawPlayer();
        }
    }
}
