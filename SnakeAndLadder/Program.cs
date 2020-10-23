using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable
            int currentPosition = 0;
            Console.WriteLine("Welcome to Snake and Ladder Problem!");            
            Console.WriteLine("Starting position is : " + currentPosition);
            //Create Reference for Random class
            Random random = new Random();
            int numberOnDie = random.Next(1, 7);
            Console.WriteLine("Number on the die rolled is : " + numberOnDie);            
        }
    }
}
