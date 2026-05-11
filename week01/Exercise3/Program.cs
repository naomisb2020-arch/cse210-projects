using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);

        int guess;

        do
        {
            Console.Write("What is your guess? ");
            string result = Console.ReadLine();
            guess = int.Parse(result);
            if(guess > magic_number)
            {
                Console.WriteLine("Lower");
                
            }
            else if(guess < magic_number)
            {
                Console.WriteLine("Higher");
                
            }
            else
            {
                Console.WriteLine("You guessed it!");
                
            } 
        }while (guess != magic_number);
    }
}