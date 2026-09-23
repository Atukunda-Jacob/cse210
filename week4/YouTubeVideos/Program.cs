using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Code in C#", "Jacob Atukunda", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks."));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));

        Video video2 = new Video("Learn Python in 10 Minutes", "Programming Hub", 450);
        video2.AddComment(new Comment("David", "Python is awesome!"));
        video2.AddComment(new Comment("Eva", "Clear explanation."));
        video2.AddComment(new Comment("Frank", "Can you make more videos?"));

        Video video3 = new Video("BYU Pathway Devotional", "BYU", 1200);
        video3.AddComment(new Comment("Sarah", "So inspiring!"));
        video3.AddComment(new Comment("John", "Thank you for this message."));
        video3.AddComment(new Comment("Grace", "I felt the Spirit."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video v in videos)
        {
            v.Display();
        }
    }
}
