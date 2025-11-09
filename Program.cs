using SnakeAndLadder.UseCases;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to Snake and Ladder Game ===\n");

            SinglePlayerUC1 uc1 = new SinglePlayerUC1();
            uc1.Execute();

            RollDiceUC2 uc2 = new RollDiceUC2();
            uc2.Execute();

            PlayerOptionUC3 uc3 = new PlayerOptionUC3();
            uc3.Execute();

            WinningPositionUC4 uc4 = new WinningPositionUC4();
            uc4.Execute();

            ExactWinningPositionUC5 uc5 = new ExactWinningPositionUC5();
            uc5.Execute();

            DiceCountUC6 uc6 = new DiceCountUC6();
            uc6.Execute();

            TwoPlayerGameUC7 uc7 = new TwoPlayerGameUC7();
            uc7.Execute();

            Console.WriteLine("\n=== Game Simulation Complete ===");
        }
    }
}
