class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(double length, double width) : base("blue")
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        double  rectangleArea = _length * _width;
        return rectangleArea;
    }
}