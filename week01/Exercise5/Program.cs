using System;
class Program
{

    static void Main(string[] args)
    {
        DisplayWelcome();

       string user_name = PromptUserName();
       int user_number = PromptUserNumber();

       int square_number = SquareNumber(user_number);

       DisplayResult(user_name, square_number);



    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int user_number = int.Parse(number);
        return user_number;
    }
    static int SquareNumber(int number)
    {
        int square_number = number * number;
        return square_number;
    }
    static void DisplayResult(string name, int square_number)
    {
        Console.WriteLine($"{name}, the square of your number is {square_number}");
    }
    

}