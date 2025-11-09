using System;

namespace SnakeAndLadder
{
    public class PlayerOptionUC3
    {
        public void Execute()
        {
            Console.WriteLine("=== Use Case 3: Check Player Option ===");

            Random random = new Random();

            int diceValue = random.Next(1, 7);

            int option = random.Next(0, 3);

            int playerPosition = 0; 

            Console.WriteLine($"Player rolled the die and got: {diceValue}");

            switch (option)
            {
                case 0:
                    Console.WriteLine("Option: No Play ? Player stays in the same position.");
                    break;

                case 1:
                    Console.WriteLine("Option: Ladder ? Player moves ahead.");
                    playerPosition += diceValue;
                    break;

                case 2:
                    Console.WriteLine("Option: Snake ? Player moves behind.");
                    playerPosition -= diceValue;
                    if (playerPosition < 0)
                        playerPosition = 0;
                    break;
            }

            Console.WriteLine($"Player current position: {playerPosition}");
            Console.WriteLine("--------------------------------------------");
        }
    }
}
