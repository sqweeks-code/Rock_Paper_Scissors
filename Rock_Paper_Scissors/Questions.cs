using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    public class Questions
    {
        public static string MakeMove()
        {
            string selection;

            Utilities.ConsoleOutput("---------------------\nPick your move from \nRock, Paper or Scissors?");
            selection = Console.ReadLine();
            selection = selection.ToUpper();

            return selection;
        }

        public static Boolean AnotherGame()
        {
            string anotherInput;
            Boolean outcome;

            Utilities.ConsoleOutput("Another Game? (Y/N)");
            anotherInput = Console.ReadLine();
            anotherInput = anotherInput.ToUpper();

            outcome = (anotherInput == "Y");

            return outcome;
        }
    }
}
