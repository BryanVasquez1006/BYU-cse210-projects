class Video
{
    //member attributes or variables

    public string _videoTitle;
    public string _videoAuthor;
    public double _videoLength;

    public List<Comment> _videoComments;

    public Video(string videoTitle, string videoAuthor, double videoLength, List<Comment> videoComments)
    {
        _videoTitle = videoTitle;
        _videoAuthor = videoAuthor;
        _videoLength = videoLength;
        _videoComments = videoComments;
    }

    //Method to compound both the comment and the video details

    public void GetVideoDetails()
    {

        Console.WriteLine($"Title: {_videoTitle} \n Author: {_videoAuthor} \n Duration: {_videoLength}");

        foreach (Comment comment in _videoComments)
        {
            Console.WriteLine(comment.GetComment());
        }




    }



}