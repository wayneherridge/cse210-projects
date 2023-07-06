using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("======================================================");
        Console.WriteLine("            Abstraction with YouTube Videos           ");
        Console.WriteLine("======================================================");
        Console.ResetColor();
        Console.WriteLine();


        List<Video> videos = new List<Video>();

        // Create videos and add comments
        Video video1 = new ConcreteVideo("A Strange New World : Daryl Dixon Official Teaser", "The Walking Dead", 26);
        video1.AddComment(new Comment("@reeduspulento", "I'm so excited to see Daryl in action again!!"));
        video1.AddComment(new Comment("@spikelilgirl", "So excited for this show!"));
        video1.AddComment(new Comment("@patrickvalentin5294", "Greatest Tv Show of all time"));
        video1.AddComment(new Comment("@lilygatschenberger8811", "I'm ready for it"));
        videos.Add(video1);
        
        Video video2 = new ConcreteVideo("Come Unto Jesus (Cover)", "Madilyn Paige", 246);
        video2.AddComment(new Comment("@cherylclowers6099", "So beautiful!  I am so touched by the Spirit...thank you!"));
        video2.AddComment(new Comment("@jatesmolino9774", "More worship songs pls"));
        video2.AddComment(new Comment("@CalledtoShare", "The perfect song."));
        video2.AddComment(new Comment("@MicahRachelle", "Thank you for shining a light to lead others to Christ."));
        videos.Add(video2);

        Video video3 = new ConcreteVideo("$50,000 Crystal Treasure Hunt", "Dude Perfect", 814);
        video3.AddComment(new Comment("@MozartTheGOAT", "Dude Perfect is reaching movie level production quality"));
        video3.AddComment(new Comment("@madskillsbmxking4174", "The gem hunting is always a fun watch!!"));
        video3.AddComment(new Comment("@tuckermontague5544", "Love these, keep them coming!"));
        video3.AddComment(new Comment("@maidintrickshots9994", "Congrats Cory! This battle was a great one"));
        videos.Add(video3);

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()} : {comment.GetText()}");
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=================================================");
            Console.ResetColor();
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}

public class ConcreteVideo : Video
{
    public ConcreteVideo(string title, string author, int length) : base(title, author, length)
    {
    }
}
