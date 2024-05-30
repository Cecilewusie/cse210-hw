using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        Comment commentbj1a = new Comment("John Wisher", "Fastastic video");
        Comment commentbj1b = new Comment("Linda Dake", "It was lit");
        Comment commentbj1c = new Comment("tec@1", "Anyone here in 2024");


        //object 1
        Video videoObj1 = new Video("Sarkodie", "New guy", 30);
        videoObj1._commentList.Add(commentbj1a);
        videoObj1._commentList.Add(commentbj1b);
        videoObj1._commentList.Add(commentbj1c);

        Comment commentObj2a = new Comment("Cecil Ewusie", "I feel very hopeful for watching this");
        Comment commentObj2b = new Comment("John Dalton", "The Lord is indeed mindful of us");
        Comment commentObj2c = new Comment("star23", "I want more content like this");

        //object 2
        Video videoObj2 = new Video("Russel M. Nelson", "The voice of Hope", 600);
        videoObj2._commentList.Add(commentObj2a);
        videoObj2._commentList.Add(commentObj2b);
        videoObj2._commentList.Add(commentObj2c);

        Comment commentObj3a = new Comment("Peter Drew", "Fantastic Video, very educative");
        Comment commentObj3b = new Comment("colepalmer", "But money is the root of all evil");
        Comment commentObj3c = new Comment("Joe", "How can I start in the first place");
        Comment commentObj3d = new Comment("timmy", "This is a great video");

        //objecft 3
        Video videoObj3 = new Video("BBC", "How to be a millionaire", 800);
        videoObj3._commentList.Add(commentObj3a);
        videoObj3._commentList.Add(commentObj3b);
        videoObj3._commentList.Add(commentObj3c);
        videoObj3._commentList.Add(commentObj3d);           


        videos.Add(videoObj1);
        videos.Add(videoObj2);
        videos.Add(videoObj3);
        
        //displaying video info
        Console.WriteLine("Here are your video info");
        foreach (Video vids in videos)
        {
            // Console.WriteLine($"Author: {vids._author}");
            // Console.WriteLine($"Tile: {vids._title}");
            // Console.WriteLine($"Lenght: {vids._length}");
            // Console.WriteLine();
            vids.DisplayVideoInfo();
            Console.WriteLine($"You have {vids.NumberOfComment()} comments on your video");
            Console.WriteLine();
            Console.WriteLine(">>Here are the comments on the video..");
            //Console.WriteLine($"{vids.GetComment()}");
            vids.DisplayComment();
            Console.WriteLine();
        }

    }
}