using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are your personal strengths?",
        "Who have you helped this week?",
        "Who are your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing Activity",
        "This activity helps you list positive things in your life.") {}

    public void Run()
    {
        StartMessage();

        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);

        Console.Write("Starting in: ");
        ShowCountdown(5);

        Console.WriteLine("\nStart listing items:");

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        EndMessage();
    }
}
