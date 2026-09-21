using System;
using System.Collections.Generic;

public class Comment
{
    private string _name;
    private string _text;
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }
    public string GetName() { return _name; }
    public string GetText() { return _text; }
}

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(Comment comment) { _comments.Add(comment); }
    public int GetNumberOfComments() { return _comments.Count; }
    public string GetTitle() { return _title; }
    public string GetAuthor() { return _author; }
    public int GetLength() { return _length; }
    public List<Comment> GetComments() { return _comments; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Learn C# in 30 Days", "Programming with Mosh", 1800);
        video1.AddComment(new Comment("John", "This video was so helpful!"));
        video1.AddComment(new Comment("Sarah", "I finally understood classes."));
        video1.AddComment(new Comment("Mike", "Great explanation of abstraction."));
        videos.Add(video1);

        Video video2 = new Video("Top 10 Hidden Features in YouTube", "Tech Tips", 900);
        video2.AddComment(new Comment("Alice", "I didn't know about these!"));
        video2.AddComment(new Comment("Bob", "Number 5 blew my mind."));
        video2.AddComment(new Comment("David", "Keep making these videos."));
        videos.Add(video2);

        Video video3 = new Video("BYU-Pathway Devotional", "BYU-Pathway", 2500);
        video3.AddComment(new Comment("Grace", "Thank you for sharing."));
        video3.AddComment(new Comment("James", "This motivated me to keep studying."));
        video3.AddComment(new Comment("Elder Uchtdorf", "Inspiring message."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}
