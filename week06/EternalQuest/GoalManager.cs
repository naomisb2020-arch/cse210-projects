using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create new goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoals();
            else if (choice == "3") SaveGoals();
            else if (choice == "4") LoadGoals();
            else if (choice == "5") RecordEvent();
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of goal are: \n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();
        Console.Write("What is the name of your goal? "); string name = Console.ReadLine();
        Console.Write("What is a short description of it? "); string desc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? "); string points = Console.ReadLine();

        if (type == "1") _goals.Add(new SimpleGoal(name, desc, points, false));
        else if (type == "2") _goals.Add(new EternalGoal(name, desc, points));
        else if (type == "3") {
            Console.Write("How many times does this goal need to be accomplished for a bonus? "); int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing in that many times? "); int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus, 0));
        }
    }

    private void ListGoals()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++) Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
    }

    private void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++) 
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
        
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int pointsEarned = int.Parse(_goals[index].GetPoints());
        _goals[index].RecordEvent();

        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");

        _score += pointsEarned;
        
        if (_goals[index] is ChecklistGoal checklist && checklist.IsComplete())
        {
            int bonus = checklist.GetBonus();
            _score += bonus;
            Console.WriteLine($"Congratulations! You have earned a bonus of {bonus} points!");
        }
        
        Console.WriteLine($"You now have {_score} points.");
    }

    private void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter sw = new StreamWriter(filename))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals) sw.WriteLine(g.GetStringRepresentation());
        }
    }

    private void LoadGoals()
    {
Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);
            _goals.Clear();

            // Empezamos desde la línea 1 porque la 0 es el score
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(":");
                string type = parts[0];

                if (type == "SimpleGoal")
                {
                    _goals.Add(new SimpleGoal(parts[1], parts[2], parts[3], bool.Parse(parts[4])));
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(parts[1], parts[2], parts[3]));
                }
                else if (type == "ChecklistGoal")
                {
                    _goals.Add(new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[5]), int.Parse(parts[4]), int.Parse(parts[6])));
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }
    }
}