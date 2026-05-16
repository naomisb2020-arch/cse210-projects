using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        
        promptGenerator._prompts.Add("Did something in nature catch your attention today?");
        promptGenerator._prompts.Add("Are you grateful for something today?");
        promptGenerator._prompts.Add("Are you thankful for someone's company, or do you miss someone?");
        promptGenerator._prompts.Add("Was something yesterday incredible and you only noticed it today?");
        promptGenerator._prompts.Add("What did you learn about yourself today?");

        string choice = "";

        
        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            
            switch (choice)
            {
                case "1":
                    
                    string customPrompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {customPrompt}");
                    
                   
                    Console.Write("> ");
                    string userResponse = Console.ReadLine();
                    
                    string currentDate = DateTime.Now.ToShortDateString();
                
                    Entry newEntry = new Entry();
                    newEntry._date = currentDate;
                    newEntry._promptText = customPrompt;
                    newEntry._entryText = userResponse;
                    
                    
                    theJournal.AddEntry(newEntry);
                    break;
                case "2":
                    theJournal.DisplayAll();
                    break;
                case "3":
                    theJournal.LoadFromFile("journal.txt");
                    break;
                case "4":
                    theJournal.SaveToFile("journal.txt");
                    break;
                case "5":
                    Console.WriteLine("Thank you for writing in your journal, see you another day!");
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}