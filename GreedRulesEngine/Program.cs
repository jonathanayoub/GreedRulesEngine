using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedRulesEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Greed!");

            while (true)
            {
                Console.WriteLine("Press \"r\" to play or any key to exit the game!");
                var key = Console.ReadKey();

                if (key.KeyChar != 'r')
                    break;

                GreedGameResult result = PlayGame();
                DisplayRolls(result.Roll.Result);
                DisplayScore(result.Score);
            }
        }

        private static GreedGameResult PlayGame()
        {
            var game = Bootstrap.BuildGame();
            var result = game.Play();
            return result;
        }

        private static void DisplayRolls(IList<int> rolls)
        {
            Console.WriteLine();
            Console.Write("Your rolls were: ");
            var rollCount = rolls.Count;
            for (int i = 0; i < rollCount; i++)
            {
                Console.Write(rolls.ElementAt(i));
                if (i == rollCount - 1)
                    break;
                Console.Write(", ");
            }

            Console.WriteLine();
        }

        private static void DisplayScore(int score)
        {
            Console.WriteLine();
            Console.WriteLine($"Your score was: {score}");
            Console.WriteLine();
        }
    }
}
