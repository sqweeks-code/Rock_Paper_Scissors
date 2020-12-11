using System;
using System.Collections.Generic;

namespace Rock_Paper_Scissors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int playerScore = 0;
            int opponentScore= 0;
            int gamesPlayed = 0;
            
            do
            {
                string selection;

                do
                {
                    selection = Questions.MakeMove();
                }
                while (!Rules.CheckInput(selection));

                string opponentSelection = Utilities.RandomMove();
                opponentSelection = opponentSelection.ToUpper();

                Utilities.ConsoleOutput($"You picked {selection}.");
                Utilities.ConsoleOutput($"I picked {opponentSelection}.");

                string decision = Rules.MatchDecision(selection, opponentSelection);
                if (decision == "Congrats You Won!!!")
                {
                    playerScore++;
                }
                else if (decision == "You LOSE!")
                {
                    opponentScore++;
                }
                gamesPlayed++;

                Utilities.ConsoleOutput(decision);
                Utilities.ConsoleOutput($"The scores on the doors are \nYou: {playerScore}, Me: {opponentScore} \nGames Played: {gamesPlayed}\n---------------------");
            }
            while (Questions.AnotherGame());
        }
        
    }
}
