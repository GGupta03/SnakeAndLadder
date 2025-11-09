using System;

namespace SnakeAndLadder
{
    public class ExactWinningPositionUC5
    {
        public void Execute()
        {
            Console.WriteLine("=== Use Case 5: Reach Exact Winning Position 100 ===");

            int playerPosition = 0;
            Random random = new Random();

            while (playerPosition < 100)
            {
    
                int diceValue = random.Next(1, 7);

                
                int option = random.Next(0, 3);

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
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("?? Player reached the Winning Position 100 exactly!");
        }
    }
}
