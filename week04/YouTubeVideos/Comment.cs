class Comment 
{
    //Creating attributes
    public string _commentAuthor;
    public string _comment;

    public Comment(string authorComment, string comment)
    {
        _commentAuthor = authorComment;
        _comment = comment;
    }

    public string GetComment()
    {
        return $"Author{_commentAuthor}\n Comment: {_comment}";
    }

}