using System;

namespace SnakeAndLadder.UseCases

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to Snake and Ladder ===\n");

            SinglePlayerUC1 useCase1 = new SinglePlayerUC1();
            useCase1.Execute();

            Console.WriteLine("\n(Use Case 1 executed successfully)");
            Console.ReadLine();
        }
    }
}
