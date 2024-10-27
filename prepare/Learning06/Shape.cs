public class Shape
{
    private string _color;

    public Shape(string color)
    {
        color = "";
    }

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public virtual double GetArea()
    {
        return -1;
    }
}