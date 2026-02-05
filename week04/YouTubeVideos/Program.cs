using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // -------- VIDEO 1 --------
        Video video1 = new Video("Learn C# in 30 Minutes", "Code Academy", 1800);
        video1.AddComment(new Comment("Alice", "Very helpful tutorial!"));
        video1.AddComment(new Comment("Brian", "I finally understand classes."));
        video1.AddComment(new Comment("Clara", "Great explanation 👍"));

        videos.Add(video1);

        // -------- VIDEO 2 --------
        Video video2 = new Video("React Native Basics", "Mobile Dev", 2400);
        video2.AddComment(new Comment("Kelvine", "This helped my app project a lot."));
        video2.AddComment(new Comment("James", "Clear and simple."));
        video2.AddComment(new Comment("Sarah", "Please make part 2!"));

        videos.Add(video2);

        // -------- VIDEO 3 --------
        Video video3 = new Video("Python for Beginners", "Tech World", 1500);
        video3.AddComment(new Comment("Mike", "Perfect for starters."));
        video3.AddComment(new Comment("Nina", "Loved the examples."));
        video3.AddComment(new Comment("Paul", "Easy to follow 👌"));

        videos.Add(video3);

        // -------- DISPLAY ALL VIDEOS --------
        foreach (Video video in videos)
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("\nComments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
