public class Word {
    private string _text;
    private bool _isHidden;

    //Creating constructors
    public Word(string wordText) 
    {
        _text = wordText;
        _isHidden = false;
    }

    //Creating Methods
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        return _text;
    }
}