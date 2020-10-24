using System;
namespace SnakeAndLadder
{
    class Program
    {
        //Constants
        const int NO_PLAY = 0;
        const int LADDER = 1;
        const int SNAKE = 2;
        const int WINNING_POSITION = 100;
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Problem!");
            int player = 0;
            //Array for 2 player
            int[] playerPosition = new int[2] { 0, 0 };
            int dieRollCount = 0;
            //While checks for player position should be less than 100.
            while (playerPosition[player] < WINNING_POSITION)
            {
                // Create Reference for Random class
                Random random = new Random();
                int numberOnDie = random.Next(1, 7);
                dieRollCount++;
                int optionCheck = random.Next(0, 3);
                //Switch assigns random option number to player
                switch (optionCheck)
                {
                    case NO_PLAY:
                        Console.WriteLine("No Play...!");
                        break;
                    case LADDER:
                        Console.WriteLine("Ladder");
                        //Sets exact winning position for player.
                        if (playerPosition[player] + numberOnDie <= 100)
                        {
                            playerPosition[player] = playerPosition[player] + numberOnDie;
                        }
                        break;
                    case SNAKE:
                        Console.WriteLine("Snake");
                        //If player position goes below zero game restarts.
                        if (playerPosition[player] < 0)
                        {
                            playerPosition[player] = 0;
                        }
                        break;
                }
                //If option is 0 ie No play or 2 ie Snake changes the turn of player.
                if (optionCheck == NO_PLAY || optionCheck == SNAKE)
                {                    
                    if (player == 0)
                    {
                        player = 1;                        
                    }
                    else
                    {                        
                        player = 0;
                    }
                }
            }
            Console.WriteLine("Player : "+ player + "wins and the die roll count is:" + dieRollCount);            
        }
    }

}