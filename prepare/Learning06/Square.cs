public class Square : Shape
{
     private double _side;

     public Square(string color, double side) 
     : base (color)
     {
        _side = side;
     }

    public override double GetArea()
    {
        double square = _side * 4;
        return square;
    }
    

}