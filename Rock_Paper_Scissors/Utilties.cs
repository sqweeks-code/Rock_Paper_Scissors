using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    public class Utilities
    {
        public static void ConsoleOutput(string input)
        {
            Console.WriteLine($"{input}");
        }

        public static string RandomMove()
        {
            var random = new Random();
            int randomMove = random.Next(GlobalVariables.listOfMoves.Count);
            string output = GlobalVariables.listOfMoves[randomMove];
            return output;
        }

    }
}
