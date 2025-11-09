using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to Snake and Ladder ===\n");

            SinglePlayerUC1 useCase1 = new SinglePlayerUC1();
            useCase1.Execute();

            RollDiceUC2 useCase2 = new RollDiceUC2();
            useCase2.Execute();

            PlayerOptionUC3 useCase3 = new PlayerOptionUC3();
            useCase3.Execute();

            WinningPositionUC4 useCase4 = new WinningPositionUC4();
            useCase4.Execute();

            ExactWinningPositionUC5 useCase5 = new ExactWinningPositionUC5();
            useCase5.Execute();

            DiceCountUC6 useCase6 = new DiceCountUC6();
            useCase6.Execute();


        }
    }
}
