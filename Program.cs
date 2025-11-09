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


        }
    }
}
