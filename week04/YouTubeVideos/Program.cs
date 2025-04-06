using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        //list to hold videos
        List<Video> videos = new List<Video>();

        //video1 with comments
        Video video1 = new Video("CSE210 - Encapsulation", "Brother Gardener", 720);
        video1.AddComment(new Comment("MadjiK", "Great course!"));
        video1.AddComment(new Comment("NgoieL", "Very helpful for my project."));
        video1.AddComment(new Comment("alTheRabbit", "Can you make one about Abstraction?"));
        videos.Add(video1);

        //video2 with comments
        Video video2 = new Video("Abstract Art Techniques", "Art Master", 540);
        video2.AddComment(new Comment("ArtLover", "Beautiful techniques!"));
        video2.AddComment(new Comment("PainterPro", "I've been doing this wrong for years!"));
        video2.AddComment(new Comment("CreativeMind", "Inspiring!"));
        video2.AddComment(new Comment("BeginnerArtist", "Where can I get these brushes?"));
        videos.Add(video2);

        // Create and add third video with comments
        Video video3 = new Video("Elevate your faith", "Madji Ngoie", 600);
        video3.AddComment(new Comment("clio", "Perfect way to start my day!"));
        video3.AddComment(new Comment("Olivia", "Been doing this routine for a month - amazing results!"));
        video3.AddComment(new Comment("Hugues", "Some actions are challenging but so rewarding"));
        videos.Add(video3);

        //display videos's information
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
    
}