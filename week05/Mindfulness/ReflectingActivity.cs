using System;
using System.Collections.Generic;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description, List<string> prompts, List<string> questions) : base(name, description)
    {
       _prompts = prompts;
       _questions = questions;

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:\n");
        DisplayPrompt();
        
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine(); 

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
        }

        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
    
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---"); 
    }
    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.Write($"> {question} ");
        

        ShowSpinner(5);
        Console.WriteLine();
    }

}