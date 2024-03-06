namespace Task1;

public abstract class Shape 
{
    public string  Description { get; set; }
    public abstract double CalculateArea();
    public virtual string PrintDescription()
    {
        return Description;
    }

}
