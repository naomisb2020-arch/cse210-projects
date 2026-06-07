// Extra: Tracks activity counts and displays a session summary on exit.
using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity(
                    "Breathing Activity", 
                    "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing."
                );
                breathing.Run();

                breathingCount++;
            }
            else if (choice == "2")
            {
                List<string> prompts = new List<string>
                {
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless."
                };

                // 2. Preparamos las listas de Preguntas oficiales
                List<string> questions = new List<string>
                {
                    "How did you feel when it was complete?",
                    "What is your favorite thing about this experience?",
                };


                ReflectingActivity reflecting = new ReflectingActivity(
                    "Reflecting Activity", 
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                    prompts,
                    questions
                );
                reflecting.Run();
                reflectingCount++;
            }
            else if (choice == "3")
            {
                
                ListingActivity listing = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing.Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("Thank you for using the Mindfulness Program.");
                
                Console.WriteLine("\n   SESSION SUMMARY    ");
                Console.WriteLine($"Breathing Activity completed: {breathingCount} time(s)");
                Console.WriteLine($"Reflecting Activity completed: {reflectingCount} time(s)");
                Console.WriteLine($"Listing Activity completed: {listingCount} time(s)");
                
                
                Console.WriteLine("\nGoodbye!\n");
            }
            else
            {
                Console.WriteLine("\nInvalid option. Please select a number from 1 to 4.");
                Thread.Sleep(2000);
            }

        }
    }
}