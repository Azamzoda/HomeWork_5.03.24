namespace Task1;

public class Circle : Shape
{
    public double Radius { get; set; }
    public override double CalculateArea()
    {
        var Pi = 3.14;
        return Pi * Radius * Radius;
    }
    public override string PrintDescription()
    {
        return base.PrintDescription();
    }
}