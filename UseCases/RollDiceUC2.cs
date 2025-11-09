using System;

namespace SnakeAndLadder.UseCases

{
    public class RollDiceUC2
    {
        public void Execute()
        {
            Console.WriteLine("=== Use Case 2: Roll the Dice ===");

            Random random = new Random();

            int diceValue = random.Next(1, 7); 

            Console.WriteLine($"Player rolled the die and got: {diceValue}");
            Console.WriteLine("--------------------------------------------");
        }
    }
}
