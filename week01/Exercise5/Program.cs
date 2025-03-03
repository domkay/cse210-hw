using System;

class Program
{
    static void Main(string[] args)
    {
        string userName;
        int userNumber;
        int squareNumber;
        void displayWelcome()
        {
            Console.WriteLine("Welcome to the program.");
        }
        string getUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }
        int getUserNumber ()
        {
            Console.Write("Please enter a number: ");
            return int.Parse(Console.ReadLine());
        }
        int computeSquareNumber (int x)
        {
            return x * x;
        }
        void displayResult ( string userName, int number)
        {
            Console.WriteLine($"{userName}, the square of your number is {squareNumber}.");
        }
        displayWelcome();
        userName = getUserName();
        userNumber = getUserNumber();
        squareNumber = computeSquareNumber(userNumber);
        displayResult(userName, squareNumber);
    }
}