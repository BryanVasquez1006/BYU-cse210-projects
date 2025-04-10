class Square : Shape
{
    private double _side;

    public Square(double side)  : base("red")
    {
        _side = side;
    }

    public override double GetArea()
    {
        double squareArea = _side * _side;
        return  squareArea;
    }
}