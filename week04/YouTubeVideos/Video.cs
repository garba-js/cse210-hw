
using System;
using System.Collections.Generic;

public class Video
{
    // Member variables
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments;

    // Constructor
    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        _comments = new List<Comment>();
    }

    // Add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Return the number of comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // Display video information and all comments
    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");

        Console.WriteLine("\nComments:");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}
