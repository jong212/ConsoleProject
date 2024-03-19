 using System;

class Program
{
    static void Main(string[] args)
    {
        // Define the initial position
        int posX = 0;
        int posY = 0;

        // Define the ASCII art with newline replaced
        string asciiArt = "\r\n\r\n    /\\_/\\\r\n   ( o.o )\r\n   (\")_(\")";
        string[] lines = asciiArt.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

        // Find the length of the longest line
        int maxLength = lines.Max(line => line.Length);

        // Calculate the height and width of the ASCII art
        int height = lines.Length;
        int width = maxLength;

        Console.WriteLine("Height: " + height);
        Console.WriteLine("Width: " + width);
        // Display the initial ASCII art
        DisplayAsciiArt(posX, posY, asciiArt);

        // Listen for keyboard input
        while (true)
        {
            // Get the pressed key
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            // Clear previous position
            ClearAsciiArt(posX, posY, asciiArt);

            // Check arrow key presses and update position
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    posY = Math.Max(0, posY - 1);
                    break;
                case ConsoleKey.DownArrow:
                    posY = Math.Min(Console.WindowHeight - CountLines(asciiArt), posY + 1);
                    break;
                case ConsoleKey.LeftArrow:
                    posX = Math.Max(0, posX - 1);
                    break;
                case ConsoleKey.RightArrow:
                    posX = Math.Min(Console.WindowWidth - GetMaxLineWidth(asciiArt), posX + 1);
                    break;
                default:
                    // Ignore other key presses
                    continue;
            }

            // Display the ASCII art at the updated position
            DisplayAsciiArt(posX, posY, asciiArt);
        }
    }

    // Function to display the ASCII art at the specified position
    static void DisplayAsciiArt(int posX, int posY, string asciiArt)
    {
        // Split the ASCII art by newline
        string[] lines = asciiArt.Split(new string[] { "\r\n" }, StringSplitOptions.None);

        // Set the cursor position for each line of the ASCII art
        for (int i = 0; i < lines.Length; i++)
        {
            Console.SetCursorPosition(posX, posY + i);
            Console.Write(lines[i]);
        }
    }

    // Function to clear the previous position of ASCII art
    static void ClearAsciiArt(int posX, int posY, string asciiArt)
    {
        // Split the ASCII art by newline
        string[] lines = asciiArt.Split(new string[] { "\r\n" }, StringSplitOptions.None);

        // Set the cursor position for each line of the ASCII art and write spaces
        for (int i = 0; i < lines.Length; i++)
        {
            Console.SetCursorPosition(posX, posY + i);
            Console.Write(new string(' ', lines[i].Length));
        }
    }

    // Function to count the number of lines in a string
    static int CountLines(string text)
    {
        return text.Split(new string[] { "\r\n" }, StringSplitOptions.None).Length;
    }

    // Function to get the maximum line width among all lines of ASCII art
    static int GetMaxLineWidth(string asciiArt)
    {
        int maxWidth = 0;

        // Split the ASCII art by newline
        string[] lines = asciiArt.Split(new string[] { "\r\n" }, StringSplitOptions.None);

        foreach (string line in lines)
        {
            if (line.Length > maxWidth)
            {
                maxWidth = line.Length;
            }
        }

        return maxWidth;
    }
}
 
/*
namespace gpt
{
    using Newtonsoft.Json;
    using System;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;

    class Api
    {
        static async Task Main()
        {
            string url = "https://api.openai.com/v1/chat/completions"; 

            var requestData = new
            {
                model = "gpt-4-1106-preview",
                messages = new[]
                {
                new { role = "system", content = "You can draw the word requested by the user precisely in ascii style, but only include ascii style in your answer" },
                new { role = "user", content = "원숭이 그려줘" }
            }
            };
            //string k = "";

            // Creating the API request
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {k}");
            var content = new StringContent(JsonConvert.SerializeObject(requestData), Encoding.UTF8, "application/json");

            // Sending the API request
            var response = await httpClient.PostAsync(url, content);

            // Receiving the API response
            var responseContent = await response.Content.ReadAsStringAsync();

            // Printing the response result
            Console.WriteLine(responseContent);
        }
    }
}
*/