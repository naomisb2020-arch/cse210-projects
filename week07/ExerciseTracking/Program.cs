using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running runningActivity = new Running("17 Jun 2026", 30, 4.8);
        Cycling cyclingActivity = new Cycling("18 Jun 2026", 45, 20.0);
        Swimming swimmingActivity = new Swimming("19 Jun 2026", 25, 30);

        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        Console.WriteLine("Exercise Tracking Summary:");
        Console.WriteLine("--------------------------");

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}