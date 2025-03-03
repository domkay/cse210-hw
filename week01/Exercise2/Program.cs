using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        int grade;
        String letter;
        String sign;
        int signValue;
        Console.Write("Please enter your grade: ");
        grade = int.Parse(Console.ReadLine());
        signValue = grade%10;
        if ( signValue >= 7)
        { 
            sign = "+";
        }
        else if (signValue < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        if (grade >= 90)
        {
            if (sign == "+")
            {
                letter  = "A";
            }
            else
            {
                letter  ="A" + sign;
            }
        }
        else if(grade >= 80)
        {
            letter  = "B" + sign;
        }
        else if(grade >= 70)
        {
            letter  = "C" + sign;
        }
        else if(grade >= 60)
        {
            letter  = "D" + sign;
        }
        else
        {
            letter  = "F";
        }
        if (letter != "F")
        {
            Console.WriteLine($"Your grade is : {letter}, you've passed!");
        }
        else
        {
            Console.WriteLine($"Your grade is : {letter}, you've failed!");
        }
        
    }
}