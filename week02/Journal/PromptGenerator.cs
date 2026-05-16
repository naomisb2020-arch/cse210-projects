using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();

        int index = randomGenerator.Next(_prompts.Count);

        return _prompts[index];
    }

}