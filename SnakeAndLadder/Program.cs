using System;

namespace SnakeAndLadder
{
    class Program
    {
        //Constants
        public const int NO_PLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int StartPosition = 0;
        public const int WinningPosition = 100;
        /// <summary>
        /// RollsDie generates number from 1 to 6.
        /// </summary>
        /// <returns></returns>
        public static int rollDie()
        {
            // Create Reference for Random class
            Random random = new Random();
            int numberOnDie = random.Next(1, 7);
            return numberOnDie;
        }
        /// <summary>
        /// News the position.
        /// </summary>
        /// <param name="numberOnDie">The number on die.</param>
        /// <returns></returns>
        public static int newPosition(int numberOnDie)
        {
            int addNumber = 0;
            Random random = new Random();
            int optionCheck = random.Next(0, 3);
            //Options for player.
            switch (optionCheck)
            {
                case NO_PLAY:                    
                    break;
                case LADDER:
                    addNumber = numberOnDie;                    
                    break;
                case SNAKE:
                    addNumber = -numberOnDie;                    
                    break;
            }
            return addNumber;
        }
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            //Variable
            int currentPosition = 0;
            int nextPosition;
            int count = 0;
            int numberOnDie = rollDie();
            Console.WriteLine("Welcome to Snake and Ladder Problem!");
            //While Checks player reaches winning position 100.
            while (currentPosition < WinningPosition)
            {
                numberOnDie = rollDie();
                count++;
                int addNumber = newPosition(numberOnDie);
                nextPosition = currentPosition + addNumber;
                if (nextPosition < 0)
                {
                    currentPosition = 0;
                }
                else
                {
                    currentPosition = nextPosition;
                }
            }            
            Console.WriteLine("Number of times the die rolled is : " + count);
            Console.WriteLine("Final position is: " + currentPosition);            
        }
    }
}
