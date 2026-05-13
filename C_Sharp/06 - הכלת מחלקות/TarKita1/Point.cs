using System;

namespace TarKita1;

public class Point
{
    private double x;
    private double y;

    public Point(double x, double y)
    {
        SetX(x);
        SetY(y);
    }
    public void SetX(double x)
    {
        this.x = x;
    }
    public void SetY(double y)
    {
        this.y = y;
    }
    public Point(Point point) : this(point.x, point.y)
    {
    }
    public double Distance(Point point) //חישוב המרחק בין 2 נקודות
    {
        return Math.Sqrt(Math.Pow((this.x - point.x), 2) + Math.Pow((this.y - point.y), 2));
    }

    public override string ToString()
    {
        return $"({x},{y})";
    }

}
