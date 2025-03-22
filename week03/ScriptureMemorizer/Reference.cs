public class Reference 
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    private string _scriptureText;


    //Creating constructors for the class
    public Reference(string book, int chapter, int verse, int endVerse, string scriptureText)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        _scriptureText = scriptureText;
    }

    public string DisplayText()
    {
        return $"{_book} {_chapter} {_verse}";
    }

    //Creating getters and setters

    public string GetBook()
    {
        return _book;
    }

    public void SetBook(string book)
    {
        _book = book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    public int GetVerse()
    {
        return _verse;
    }

    public void SetVerse(int verse)
    {
        _verse = verse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }

    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }

    public string GetScriptureText()
    {
        return _scriptureText;
    }

    public void SetScriptureText(string scriptureText)
    {
        _scriptureText = scriptureText;
    }
}
