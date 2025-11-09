using System;

namespace SnakeAndLadder.UseCases
{
    public class TwoPlayerGameUC7
    {
        public void Execute()
        {
            Console.WriteLine("=== Use Case 7: Two Player Snake and Ladder Game ===\n");

            int player1Position = 0;
            int player2Position = 0;
            int currentPlayer = 1; 
            Random random = new Random();

            while (player1Position < 100 && player2Position < 100)
            {
                int diceValue = random.Next(1, 7);
                int option = random.Next(0, 3); 

                Console.WriteLine($"\n Player {currentPlayer} rolls the die and gets: {diceValue}");

                if (currentPlayer == 1)
                {
                    player1Position = UpdatePosition(player1Position, diceValue, option, currentPlayer);

                    
                    if (option != 1)
                        currentPlayer = 2;
                }
                else
                {
                    player2Position = UpdatePosition(player2Position, diceValue, option, currentPlayer);

                    
                    if (option != 1)
                        currentPlayer = 1;
                }
            }

            Console.WriteLine("\n--------------------------------------------");
            if (player1Position == 100)
                Console.WriteLine("Player 1 Wins the Game!");
            else
                Console.WriteLine("Player 2 Wins the Game!");
        }

        
        private int UpdatePosition(int playerPosition, int diceValue, int option, int playerNumber)
        {
            switch (option)
            {
                case 0:
                    Console.WriteLine($"No Play ? Player {playerNumber} stays at position {playerPosition}");
                    break;

                case 1:
                    if (playerPosition + diceValue <= 100)
                    {
                        playerPosition += diceValue;
                        Console.WriteLine($"Ladder ? Player {playerNumber} moves ahead by {diceValue}, New Position: {playerPosition}");
                        Console.WriteLine($"?? Player {playerNumber} gets another turn!");
                    }
                    else
                    {
                        Console.WriteLine($"Ladder ? Dice {diceValue} exceeds 100, Player {playerNumber} stays at {playerPosition}");
                    }
                    break;

                case 2:
                    playerPosition -= diceValue;
                    if (playerPosition < 0)
                        playerPosition = 0;
                    Console.WriteLine($"Snake ? Player {playerNumber} moves behind by {diceValue}, New Position: {playerPosition}");
                    break;
            }

            return playerPosition;
        }
    }
}
