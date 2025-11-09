using System;

namespace SnakeAndLadder
{
    public class DiceCountUC6
    {
        public void Execute()
        {
            Console.WriteLine("=== Use Case 6: Dice Count and Position After Each Roll ===");

            int playerPosition = 0;
            int diceRollCount = 0;
            Random random = new Random();

            while (playerPosition < 100)
            {
                diceRollCount++;

                int diceValue = random.Next(1, 7);

                int option = random.Next(0, 3);

                Console.WriteLine($"\nRoll {diceRollCount}: Dice Value = {diceValue}");

                switch (option)
                {
                    case 0:
                        
                        Console.WriteLine($"No Play ? Player stays at position {playerPosition}");
                        break;

                    case 1:
                        
                        if (playerPosition + diceValue <= 100)
                        {
                            playerPosition += diceValue;
                            Console.WriteLine($"Ladder ? Player moves ahead by {diceValue}, New Position: {playerPosition}");
                        }
                        else
                        {
                            Console.WriteLine($"Ladder ? Dice value {diceValue} exceeds 100, stay at {playerPosition}");
                        }
                        break;

                    case 2:
                        
                        playerPosition -= diceValue;
                        if (playerPosition < 0)
                            playerPosition = 0;
                        Console.WriteLine($"Snake ? Player moves behind by {diceValue}, New Position: {playerPosition}");
                        break;
                }

                Console.WriteLine("--------------------------------------------");
            }

            Console.WriteLine($"\n?? Player reached the Winning Position 100!");
            Console.WriteLine($"?? Total Dice Rolls to Win: {diceRollCount}");
        }
    }
}
