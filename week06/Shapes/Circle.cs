class Circle : Shape 
{
    private double _radius;

    public Circle(double radius) : base("yellow")
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double area = Math.PI * (_radius * _radius);
        return area;
    }
}