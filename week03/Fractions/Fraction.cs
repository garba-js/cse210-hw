public class Fraction
{
    private int _top;
    private int _bottom;

    // 1. No-parameter constructor (defaults to 1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // 2. One-parameter constructor (top only, denominator defaults to 1)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // 3. Two-parameter constructor (top and bottom)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and Setters for Top (Numerator)
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    // Getters and Setters for Bottom (Denominator)
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Methods to return representations
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        // Cast to double to ensure accurate floating-point division
        return (double)_top / _bottom;
    }
}