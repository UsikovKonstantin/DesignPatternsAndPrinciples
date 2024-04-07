using _07._Flyweight.ConcreteFlyweights;

namespace _07._Flyweight.FlyweightFactory;

public class ShapeFactory
{
	private Dictionary<int, Circle> _circles = new Dictionary<int, Circle>();
	private Dictionary<int, Square> _squares = new Dictionary<int, Square>();
	private Dictionary<(int, int), Rectangle> _rectangles = new Dictionary<(int, int), Rectangle>();
	private Point? _point;

    public ShapeFactory()
    {
        
    }

    public Circle CreateCircle(int radius)
    {
        if (!_circles.ContainsKey(radius))
        {
            _circles[radius] = new Circle(radius);
		}
        return _circles[radius];
    }

	public Square CreateSquare(int side)
	{
		if (!_squares.ContainsKey(side))
		{
			_squares[side] = new Square(side);
		}
		return _squares[side];
	}

	public Rectangle CreateRectangle(int sideA, int sideB)
	{
		if (!_rectangles.ContainsKey((sideA, sideB)))
		{
			_rectangles[(sideA, sideB)] = new Rectangle(sideA, sideB);
		}
		return _rectangles[(sideA, sideB)];
	}

	public Point CreatePoint()
	{
		if (_point == null)
		{
			_point = new Point();
		}
		return _point;
	}
}
