using System;

internal class Learning
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int number = randomNumber.Next(1, 101);
        int guesses = 0;
        while (true)
        {
            Console.WriteLine("Guess a number between 1 - 100");
            int guessedNumber = Convert.ToInt32(Console.ReadLine());
            if (guessedNumber == number)
            {
                Console.WriteLine("Congratulations, you guessed the number, the correct answer is: " + number);
                Console.WriteLine("Tries: " + guesses);
                while (true)
                {
                    Console.WriteLine("Would you like to continue? Y/N");
                    String choice = Console.ReadLine();
                    number = randomNumber.Next(1, 101);
                    guesses = 0;
                    switch (choice)
                    {
                        case "Y":
                            Console.Clear();
                            break;
                        case "y":
                            Console.Clear();
                            break;
                        case "N":
                            Console.WriteLine("Goodbye!");
                            Console.WriteLine("Press any key, to leave the application.");
                            Console.ReadKey();
                            Console.Clear();
                            System.Environment.Exit(0);
                            break;
                        case "n":
                            Console.WriteLine("Goodbye!");
                            Console.WriteLine("Press any key, to leave the application.");
                            Console.ReadKey();
                            Console.Clear();
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("You've typed the wrong answer, please try again.");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                            break;
                    }
                    break;
                }
                continue;
            }
            else
            {
                if (guessedNumber <= 0 || guessedNumber > 100)
                {
                    Console.WriteLine("The number is out of range!");
                    Console.WriteLine("Please write down the number again.");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                if (guessedNumber < number)
                {
                    Console.WriteLine("The number is too low!");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    guesses++;
                    continue;
                }
                if (guessedNumber > number)
                {
                    Console.WriteLine("The number is too high!");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    guesses++;
                    continue;
                }
            }
            break;
        }
    }
}