using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        // Test base Assignment class
        Assignment assignment = new Assignment("Madji K.", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        // Test MathAssignment
        MathAssignment mathAssignment = new MathAssignment("Joyce Ka.", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Test WritingAssignment
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}