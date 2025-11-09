using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to Snake and Ladder Game ===\n");

            // Use Case 1: Single Player Start
            SinglePlayerUC1 useCase1 = new SinglePlayerUC1();
            useCase1.Execute();

            // Use Case 2: Roll Dice
            RollDiceUC2 useCase2 = new RollDiceUC2();
            useCase2.Execute();

            // Use Case 3: Player checks for Option (No Play, Ladder, Snake)
            CheckOptionUC3 useCase3 = new CheckOptionUC3();
            useCase3.Execute();

            // Use Case 4: Repeat till the Player reaches 100 (restart if below 0)
            ReachWinningPositionUC4 useCase4 = new ReachWinningPositionUC4();
            useCase4.Execute();

            // Use Case 5: Ensure exact winning position 100
            ExactWinningPositionUC5 useCase5 = new ExactWinningPositionUC5();
            useCase5.Execute();

            // Use Case 6: Report number of dice rolls and position after each roll
            ReportDiceCountUC6 useCase6 = new ReportDiceCountUC6();
            useCase6.Execute();

            // Use Case 7: Two Player Game with Ladder Replay and Winner Report
            TwoPlayerGameUC7 useCase7 = new TwoPlayerGameUC7();
            useCase7.Execute();

            Console.WriteLine("\n=== Game Simulation Complete ===");
        }
    }
}
