using System;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> comment= new List<Comment>
        {
            new Comment("Paul Artreides", "Hey yo, great video"),
        };

        Video video1= new Video("C# in 5 minutes", "Bryan Vasquez", 5.34, comment);

        video1.GetVideoDetails();
        
    }
}