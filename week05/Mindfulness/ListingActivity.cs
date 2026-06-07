using System;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private int _count;

    public ListingActivity(string name, string description) : base(name, description)  
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Spirit this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many items as you can as they relate to the following prompt:");
        GetRandomPrompt(); 

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> itemsList = GetListFromUser();
        
        _count = itemsList.Count;

        Console.WriteLine($"You listed {_count} items!\n");

        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        
        Console.WriteLine($"--- {_prompts[index]} ---");
    }



    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(input))
            {
                userList.Add(input);
            }
        }

        return userList;
    }

}