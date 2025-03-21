public class Fractions
{
    //Setting attributes for the top and bottom digits of the fraction
    private int _top;
    private int _bottom;

    //Creating the constructors

    //constructor that initializes the attributes to 1
    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(int number)
    {
        _top = number;
        _bottom = 1;
    }

    public Fractions(int topNum, int bottomNum)
    {
        _top = topNum;
        _bottom = bottomNum;
    }

    //Creating getters and setters for both attributes

    public int GetTopNum()
    {
        return _top;
    }

    public int SetTopNum(int topNum)
    {
        return _top = topNum;
    }


    public int GetBottomNum()
    {
        return _bottom;
    }

    public void SetBottomNum(int bottomNum)
    {
        _bottom = bottomNum;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}