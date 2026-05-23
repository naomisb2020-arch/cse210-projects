/*
EXTRA:
- Added a Scripture Library using List<Scripture>.
- The program automatically selects a random scripture from the list 
  on startup using the Random class.
*/
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Scripture> scriptureLibrary = new List<Scripture>();
        
        Reference ref1 = new Reference("Proverbs", 3, 5, 6);
        string text1 = "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths";
        scriptureLibrary.Add(new Scripture(ref1, text1));

        
        Reference ref2 = new Reference("John", 3, 16);
        string text2 = "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life";
        scriptureLibrary.Add(new Scripture(ref2, text2));

        
        Reference ref3 = new Reference("Philippians", 4, 13);
        string text3 = "I can do all things through Christ which strengtheneth me";
        scriptureLibrary.Add(new Scripture(ref3, text3));


        
        Random random = new Random();
        int randomIndex = random.Next(scriptureLibrary.Count);
        
        
        Scripture scripture = scriptureLibrary[randomIndex];


        
        string input = "";

        while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();

        
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            
            Console.WriteLine("Press ENTER to hide words or type 'quit' to finish:");
            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                scripture.HideRandomWords(3); 
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nGood job! You have finished or exited the program.");
    }
}
