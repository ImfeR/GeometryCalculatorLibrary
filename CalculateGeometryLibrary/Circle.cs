namespace CalculateGeometryLibrary;

public class Circle : Shape
{
    #region Fields

    private int _radius;

    #endregion

    #region Properties

    public int Radius
    {
        get { return _radius; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Radius mast be positive number and not 0, but was = {value}");
            }

            _radius = value;
        }
    }

    #endregion
    
    #region Constructors

    public Circle(int radius)
    {
        Radius = radius;
    }

    #endregion

    #region Methods

    internal override double GetFigureSquare()
    {
        return Math.Round(Math.PI * Math.Pow(_radius, 2), 3);
    }

    #endregion
}