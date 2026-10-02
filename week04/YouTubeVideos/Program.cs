using System;
using System.Collections.Generic;  

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

        Video video1 = new Video("Driving lessons", "AA Driving School", 600);
        Video video2 = new Video("Training a dog", "NatGeo Wild", 900);
        Video video3 = new Video("Python Programming", "Programming with Mosh", 450);

        video1._comments.Add(new Comment("Awino", "Great tutorial lessons!"));
        video1._comments.Add(new Comment("James", "Helped me a lot."));
        video1._comments.Add(new Comment("Carlos", "Can now program confidentaly."));

        video2._comments.Add(new Comment("Dante", "My driving rocks!"));
        video2._comments.Add(new Comment("Evelyne", "What dog breed?"));
        video2._comments.Add(new Comment("Frank", "Thanks!"));

        video3._comments.Add(new Comment("Grace", "Loved the experience."));
        video3._comments.Add(new Comment("Henry", "Doesn't work with my dog."));
        video3._comments.Add(new Comment("Ivy", "Mosh all the way!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"  {comment._commenterName}: {comment._commentText}");
            }

            Console.WriteLine(); 
        }
    }
}   