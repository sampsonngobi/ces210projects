using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video ("Human Anatomy", "SNC Ikedi", 300);
        v1._comments.Add(new Comment("John", "Great video"));
        v1._comments.Add(new Comment("Mary", "Very informative"));
        v1._comments.Add(new Comment("Bob", "Could be more detailed"));
        v1._comments.Add(new Comment("Sam","Thank you for this video"));


        Video v2 = new Video ("Human Physiology", "JC Okeke", 200);
        v2._comments.Add(new Comment("Jane", "Interesting video"));
        v2._comments.Add(new Comment("Mike", "Good explanation"));
        v2._comments.Add(new Comment("Sarah", "Clear and concise"));
        v2._comments.Add(new Comment("Tom", "Well done"));
        v2._comments.Add(new Comment("John", "Clear and concise"));
        v2._comments.Add(new Comment("Sampson Ngobi", "Well done"));

        Video v3 = new Video ("Intro to Human biology", "JC Okeke", 500);
        v3._comments.Add(new Comment("Kate brown", "Interesting video"));
        v3._comments.Add(new Comment("jessy Mike", "Good Animation"));
        v3._comments.Add(new Comment("Sarah", "very clear and concise"));
        v3._comments.Add(new Comment("Tom", "Well taught"));

        Video v4 = new Video ("Human Cell and organs", "JC Okeke", 100);
        v4._comments.Add(new Comment("Jannet Sam", "Facinating video"));
        v4._comments.Add(new Comment("Mike", "Good explanation"));
        v4._comments.Add(new Comment("Sarah", "Clear and concise"));
       



        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);
        videos.Add(v4);

        foreach(Video video in videos)
        {   
            Console.WriteLine();
            Console.WriteLine($"Video Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Duration: {video.GetLength()} seconds");
            Console.WriteLine($"This video has {video.GetCommentCount()} comments\n");
            Console.WriteLine("COMMENTS:");

            foreach(Comment comment in video._comments)
            { 
                Console.WriteLine($"{comment.GetCommenter()}: {comment.GetText()}"); 
            }
        }
    }
}