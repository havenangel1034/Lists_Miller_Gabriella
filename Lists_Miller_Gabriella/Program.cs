using System;
using System.Collections.Generic;

namespace Lists_Miller_Gabriella
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            foreach(string game in games)
            {
                Console.WriteLine(game);
            }

            Console.WriteLine($"\nGames in list: {games.Count}");

            games.AddRange(otherGames);

            Console.WriteLine($"\nGames in list: {games.Count}");

            if (games.Contains("FNAF"))
            {
                Console.WriteLine("\nWAS THAT THE BITE OF '87?!?!?!?!?");
            }
            else
            {
                games.Add("FNAF");
            }

            int  myInt = 6;

            if(myInt < games.Count)
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("\nGame not found!");
            }

            Console.WriteLine("\nAll games in the list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            games.Sort();

            Console.WriteLine("\nSorted games in list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            string[] newList = new string[games.Count];

            games.CopyTo(newList);

            games.Clear();


            Console.WriteLine("\nNew List:");
            foreach(string game in newList)
            {
                Console.WriteLine(game);
            }
        }
    }
}