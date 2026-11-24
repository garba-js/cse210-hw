using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        // Create the first video
        Video video1 = new Video(
            "Introduction to C# Programming",
            "Programming With Mosh",
            600
        );

        video1.AddComment(new Comment("John", "This is a very helpful introduction."));
        video1.AddComment(new Comment("Mary", "I finally understand the basics of C#."));
        video1.AddComment(new Comment("David", "Great explanation for beginners."));
        video1.AddComment(new Comment("Sarah", "Looking forward to the next lesson."));

        // Create the second video
        Video video2 = new Video(
            "Learn HTML and CSS for Beginners",
            "freeCodeCamp",
            1800
        );

        video2.AddComment(new Comment("Peter", "This tutorial is excellent."));
        video2.AddComment(new Comment("Grace", "I learned a lot from this video."));
        video2.AddComment(new Comment("Michael", "Very easy to understand."));
        video2.AddComment(new Comment("Esther", "Thank you for sharing this resource."));

        // Create the third video
        Video video3 = new Video(
            "Understanding Object-Oriented Programming",
            "Bro Code",
            900
        );

        video3.AddComment(new Comment("James", "OOP makes more sense now."));
        video3.AddComment(new Comment("Ruth", "The examples were very useful."));
        video3.AddComment(new Comment("Daniel", "Excellent teaching method."));
        video3.AddComment(new Comment("Faith", "I enjoyed learning about classes."));

        // Create the fourth video
        Video video4 = new Video(
            "JavaScript Full Course",
            "SuperSimpleDev",
            2400
        );

        video4.AddComment(new Comment("Paul", "This is exactly what I needed."));
        video4.AddComment(new Comment("Joy", "Very detailed and informative."));
        video4.AddComment(new Comment("Samuel", "I appreciate this tutorial."));
        video4.AddComment(new Comment("Rebecca", "Can't wait to practice what I learned."));

        // Create a list to store all videos
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine("\n========================================");
            video.DisplayDetails();
            Console.WriteLine("========================================");
        }
    }
}
