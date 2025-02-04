using System;
using System.Collections.Generic;

namespace Lists_Miller_Gabriella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of popular games.
            List<string> games = new List<string>
            {
                "Minecraft",
                "Roblox",
                "Marvel Rivals",
                "Multiverses",
                "Genshin Impact",
                "Life is Strange",
                "Destiny 2",
                "Red Dead Redemption 2",
            };

            // Create an array containing multiple FNAF games.
            string[] otherGames = new string[]
            {
                "FNAF",
                "FNAF 2",
                "FNAF 3",
                "FNAF 4",
                "FNAF World",
                "FNAF SL",
                "FNAF Pizzeria Simulator",
                "FNAF Ultimate Custom Night",
                "FNAF: Help Wanted",
                "FNAF: Special Delivery",
                "FNAF: Security Breach",
                "FNAF: Help Wanted 2",
            };

            // Print each game from the original list
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Display the current count of games in the list.
            Console.WriteLine($"\nGames in list: {games.Count}");

            // Add all games from the otherGames array to the games list.
            games.AddRange(otherGames);

            // Display the updated count of games in the list.
            Console.WriteLine($"\nGames in list: {games.Count}");

            // Check if "FNAF 4" is present in the list.
            if (games.Contains("FNAF 4"))
            {
                Console.WriteLine("\nWAS THAT THE BITE OF '87?!?!?!?!?");
            }
            else
            {
                // Add "FNAF" to the list if it's not already present.
                games.Add("FNAF 4");
            }

            // Define an integer for an index.
            int myInt = 6;

            // If the index is within the list range, remove the game at that index.
            if (myInt < games.Count)
            {
                games.RemoveAt(myInt);
            }
            else
            {
                // If the index is out of bounds, print an error message.
                Console.WriteLine("\nGame not found!");
            }

            // Print all games in the list after modification.
            Console.WriteLine("\nAll games in the list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Sort the list of games alphabetically.
            games.Sort();

            // Print all games after sorting.
            Console.WriteLine("\nSorted games in list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Create a new string array with the same size as the list.
            string[] newList = new string[games.Count];

            // Copy all elements from the list to the new array.
            games.CopyTo(newList);

            // Clear all elements from the original list.
            games.Clear();



            // Print all games now stored in the new array.
            Console.WriteLine("\nNew List:");
            foreach(string game in newList)
            {
                Console.WriteLine(game);
            }
        }
    }
}