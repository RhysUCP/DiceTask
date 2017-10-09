using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cup cup = new Cup();

            while (true)
            {
                Console.WriteLine("Please select the size of the dice to add to a cup. Options: 4, 6, 8, 10, 12, 20");
                int size = Convert.ToInt32(Console.ReadLine());
                Die die = new Die(size);
                cup.AddDice(die);
                Console.WriteLine("Added dice to cup! Current dice in cup: " + cup.WriteDie());
                Console.WriteLine("Press 'Y' to add another or press 'N' to end.");                
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.N)
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("Rolling dice in cup...");
            Console.WriteLine("Total value = " + cup.RollDie());


        }
    }
}
