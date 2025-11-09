using System;

namespace SnakeAndLadder.UseCases

{
    // Use Case 2: Player rolls the die to get a number between 1 and 6
    public class RollDiceUC2
    {
        public void Execute()
        {
            Console.WriteLine("=== Use Case 2: Roll the Dice ===");

            Random random = new Random();

            // Generate random number between 1 and 6
            int diceValue = random.Next(1, 7); 

            Console.WriteLine($"Player rolled the die and got: {diceValue}");
            Console.WriteLine("--------------------------------------------");
        }
    }
}
