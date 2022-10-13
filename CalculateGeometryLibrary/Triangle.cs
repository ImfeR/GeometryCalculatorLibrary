namespace CalculateGeometryLibrary;

public class Triangle : Shape
{
    #region Fields
    
    private int _firstEdge = 1;
    private int _secondEdge = 1;
    private int _thirdEdge = 1;

    #endregion

    #region Properties

    public int FirstEdge
    {
        get { return _firstEdge; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"First edge must be positive number and not 0, but was = {value}");
            }

            _firstEdge = value;
        }
    }
    public int SecondEdge
    {
        get { return _secondEdge; }
        set 
        {         
            if (value <= 0)
            {
                throw new ArgumentException($"Second edge must be positive number and not 0, but was = {value}");
            }

            _secondEdge = value;
        }
    }

    public int ThirdEdge
    {
        get { return _thirdEdge; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Second edge must be positive number and not 0, but was = {value}");
            }

            _thirdEdge = value;
        }
    }

    public bool IsTriangleRight => IsTriangleCanExists() && CheckIsTriangleRight();

    #endregion

    #region Construcotrs

    public Triangle(int firstEdge, int secondEdge, int thirdEdge)
    {
        FirstEdge = firstEdge;
        SecondEdge = secondEdge;
        ThirdEdge = thirdEdge;
        
        if (!IsTriangleCanExists())
        {
            throw new ArgumentException(
                "The triangle cannot exist. The sum of the two sides must be greater than the third");
        }
    }

    #endregion

    #region Methods

    internal override double GetFigureSquare()
    {
        if (!IsTriangleCanExists())
        {
            throw new ArgumentException(
                "The triangle cannot exist. The sum of the two sides must be greater than the third");
        }
        
        var halfMeter = Math.Round(((double)_firstEdge + (double)_secondEdge + (double)_thirdEdge) / 2, 4);

        return Math.Round(
            Math.Sqrt(halfMeter * (halfMeter - _firstEdge) * (halfMeter - _secondEdge) * (halfMeter - _thirdEdge)), 3);
    }

    private bool CheckIsTriangleRight()
    {
        var firstEdgeSquare = (int)Math.Pow(FirstEdge, 2);
        var secondEdgeSquare = (int)Math.Pow(SecondEdge, 2);
        var thirdEdgeSquare = (int)Math.Pow(ThirdEdge, 2);
        
        if (firstEdgeSquare + secondEdgeSquare == thirdEdgeSquare 
            || firstEdgeSquare + thirdEdgeSquare == secondEdgeSquare
            || secondEdgeSquare + thirdEdgeSquare == firstEdgeSquare)
        {
            return true;
        }

        return false;
    }
    
    private bool IsTriangleCanExists()
    {
        if (FirstEdge + SecondEdge <= ThirdEdge)
        {
            return false;
        }

        if (FirstEdge + ThirdEdge <= SecondEdge)
        {
            return false;
        }

        if (SecondEdge + ThirdEdge <= FirstEdge)
        {
            return false;
        }
        
        return true;
    }

    #endregion
}