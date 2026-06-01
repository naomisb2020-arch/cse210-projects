using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video video1 = new Video("Step-by-Step Recipe for a Fluffy Vanilla Cake", "Chef Maria", 450);

        
        video1.AddComment(new Comment("Lucia", "It turned out delicious! Thanks for the oven tip."));
        video1.AddComment(new Comment("Esteban", "My cake didn't rise that much, what did I do wrong?"));
        video1.AddComment(new Comment("Clara", "The best vanilla recipe I have ever tried."));

        videoList.Add(video1);

        Video video2 = new Video("Tech News of the Year", "Gadget Reviewer", 900);

        
        video2.AddComment(new Comment("Roberto", "I can't wait for that new processor to come out!"));
        video2.AddComment(new Comment("Elena", "Too expensive for what it offers this year."));
        video2.AddComment(new Comment("Gabriel", "Excellent summary of the new hardware updates."));

        videoList.Add(video2);

        Video video3 = new Video("Main Industrial Production Sectors in the World", "Global Economics", 720);

        
        video3.AddComment(new Comment("John", "Very interesting data, especially the growth in the automotive sector."));
        video3.AddComment(new Comment("Sarah", "It is impressive how automation is changing manufacturing everywhere."));
        video3.AddComment(new Comment("David", "Great overview! This helped me a lot for my university research."));

        videoList.Add(video3);

        Console.WriteLine("--- YOUTUBE PLAYLIST ---\n");

        
        foreach (Video video in videoList)
        {
            
            video.Display();

        
    }
}
}