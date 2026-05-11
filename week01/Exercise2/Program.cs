using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("\nWhat is your grade percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        if (percent >= 90)
        {
           Console.WriteLine("Your grade is A");
        }

        else if (percent >= 80 && percent < 90)
        {
            Console.WriteLine("Your grade is B"); 
        }

        else if (percent >= 70)
        {
            Console.WriteLine("Your grade is C");
        }
    

        else if (percent >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }


        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
           Console.WriteLine("Better luck next time!"); 
        }
    }
}