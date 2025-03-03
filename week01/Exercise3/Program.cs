using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello This the GUESS GAME.");
        string response = "yes";
        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);
            int guess;
            int userNumber;
            guess = number;
            int counts = 0;
            do
            {
                Console.Write("Guess a number: ");
                userNumber = int.Parse(Console.ReadLine());
                counts ++;
                if (guess > userNumber)
                {
                    Console.WriteLine("Higher.");
                }
                else if (guess < userNumber)
                {
                    Console.WriteLine("Lower.");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You've tried {counts} time(s).");
                }
            } while (guess != userNumber);
            Console.Write("Continue? (yes/no) ");
            response = Console.ReadLine();
        }
    }
}