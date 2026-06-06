using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathTask = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "3-10, 20-21");

        Console.WriteLine(mathTask.GetSummary());

        Console.WriteLine(mathTask.GetHomeworkList());



        WritingAssignment writingTask = new WritingAssignment("Mary Waters", "European History", "The Causes of WWII");

        Console.WriteLine(writingTask.GetSummary());

        Console.WriteLine(writingTask.GetWritingInformation());

    }
}