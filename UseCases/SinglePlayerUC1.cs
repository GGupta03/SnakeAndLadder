using System;

namespace SnakeAndLadder
{
    public class SinglePlayerUC1
    {
        private int playerPosition;

        public SinglePlayerUC1()
        {
            playerPosition = 0;
        }

        public void Execute()
        {
            Console.WriteLine("Snake and Ladder game initialized with a single player.");
            Console.WriteLine($"Player starts at position: {playerPosition}");
            Console.WriteLine("--------------------------------------------");
        }
    }
}
