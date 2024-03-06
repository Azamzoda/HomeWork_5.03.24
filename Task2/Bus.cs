namespace Task2;

public class Bus : IMovable
{
    string _color;
    double _speed;
    string _model;
    public Bus(string color, double speed, string model)
    {
        _color = color; 
        _speed = speed;
        _model = model;
    }
    public string MoveLeft()
    {
        return $"The bus move to left";
    }

    public string MoveRight()
    {
        return $"The bus move to right";
    }

}
