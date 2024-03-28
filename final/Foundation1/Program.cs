using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Health Benefits of Banana Peels", "Not A Monkey", 120);
        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "Interesting content.");
        video1.AddComment("User3", "I learned a lot.");
        videos.Add(video1);

        Video video2 = new Video("Comprehensive Overview of the US Constitution", "Ben Franklin", 180);
        video2.AddComment("User4", "Nice work!");
        video2.AddComment("User5", "Very informative.");
        video2.AddComment("User6", "Could be better.");
        videos.Add(video2);

        Video video3 = new Video("Paint Drying (9 Hour Edition)", "Sell-Out84", 150);
        video3.AddComment("User7", "Loved it!");
        video3.AddComment("User8", "Could watch it again.");
        video3.AddComment("User9", "Not my cup of tea.");
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}
