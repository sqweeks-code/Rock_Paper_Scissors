using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    public class Rules
    {

        public static bool CheckInput(string playerSelection)
        {
            bool output = GlobalVariables.listOfMoves.Contains(playerSelection);
            
            if (output == false)
            {
                Utilities.ConsoleOutput("Move selection is invalid!");
            };

            return output;
        }

        public static string MatchDecision(string playerMove, string opponentMove)
        {
            string outcome;

            if ((playerMove == "ROCK" && opponentMove == "SCISSORS")
                || (playerMove == "SCISSORS" && opponentMove == "PAPER")
                || (playerMove == "PAPER" && opponentMove == "ROCK"))
            {
                outcome = "Congrats You Won!!!";
            }
            else if ((playerMove == "ROCK" && opponentMove == "ROCK")
                || (playerMove == "SCISSORS" && opponentMove == "SCISSORS")
                || (playerMove == "PAPER" && opponentMove == "PAPER"))
            {
                outcome = "Its a Draw.";
            }
            else if ((playerMove == "ROCK" && opponentMove == "PAPER")
                || (playerMove == "SCISSORS" && opponentMove == "ROCK")
                || (playerMove == "PAPER" && opponentMove == "SCISSORS"))
            {
                outcome = "You LOSE!";
            }
            else
            {
                outcome = "Something went wrong!!!";
            }
            return outcome;
        }
    }
}
