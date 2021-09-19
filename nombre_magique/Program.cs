using System;

namespace nombre_magique
{
    class Program
    {
        static int AskForNumber(int min, int max)
        {
            int userNum = max + 1;             

            while ((userNum < min) || (userNum > max))
            {
                Console.Write($"Enter a number between {min} & {max}: ");
                string userNumStr = Console.ReadLine();

                try
                {
                    userNum = int.Parse(userNumStr);

                    if ((userNum < min) || (userNum > max))
                    {
                        Console.WriteLine($"The number most be between {min} & {max}");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please, enter a valid number.");
                }
            }

            return userNum;
        }
        static void Main(string[] args)
        {

            const int NBRE_MIN = 1;
            const int NBRE_MAX = 10;
            // Generate random number between a minimum and a maximum number
            int nombreMagic = new Random().Next(NBRE_MIN, NBRE_MAX + 1);

            int validNum = NBRE_MAX + 1;
            
            for(int nbreVies = 4; nbreVies > 0; nbreVies--)
            {
                Console.WriteLine();
                Console.WriteLine($"Lives left: {nbreVies}");
                validNum = AskForNumber(NBRE_MIN, NBRE_MAX);

                if (validNum < nombreMagic)
                {
                    Console.WriteLine("The magic number is greater");
                }
                else if (validNum > nombreMagic)
                {
                    Console.WriteLine("The magic number is less");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Bravo! You got the magic number.");
                    break;
                }
            }

            if (validNum != nombreMagic)            
            {
                Console.WriteLine();
                Console.WriteLine($"Game Over, the magic number was {nombreMagic}");
            }
        }
    }
}
