using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DanishLottery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sets the title of the CMD
            Console.Title = "Lottery Drawing";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Danish Lottery Drawing\n");

                // Create a random number generator
                Random random = new Random();

                // Draw 7 regular numbers
                int[] lottoNumbers = new int[6];
                int jokerNumber = random.Next(1, 37);
                Console.Write("Numbers: ");
                for (int i = 0; i < lottoNumbers.Length; i++)
                {
                    Thread.Sleep(2000); // Wait for 2 seconds
                    lottoNumbers[i] = random.Next(1, 37);
                    Console.Write(lottoNumbers[i] + " ");
                }
                Console.ForegroundColor = ConsoleColor.Red; // Change color to red
                Console.Write(jokerNumber);
                Console.ResetColor(); // Reset color

                Console.WriteLine("\n\nPress any key to try again...");
                Console.ReadKey();
            }
        }
    }
}
