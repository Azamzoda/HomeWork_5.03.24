namespace Task1;

public class Ractangle : Shape
{
   public double Length { get; set; }
   public  double  Width { get; set; }
    public override double CalculateArea()
    {
        return Length * Width;
    }
    public override string PrintDescription()
    {
        return base.PrintDescription();
    }

}
