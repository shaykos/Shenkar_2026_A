using System;

namespace TarKita1;

public class Triangle
{
    //קודקודים של המשולש
    private Point A;
    private Point B;
    private Point C;

    //צלעות המשולש  
    private double a;
    private double b;
    private double c;

    public Triangle(Point A, Point B, Point C)
    {
        this.A = A;
        this.B = B;
        this.C = C;

        a = B.Distance(C);
        b = A.Distance(C);
        c = A.Distance(B);
    }

    public double Perimeter() //היקף המשולש
    {
        return a + b + c;
    }

    public override string ToString()
    {
        return $"Points: {A}, {B}, {C}\nSides: {a:F2}, {b:F2}, {c:F2}\nPerimeter: {Perimeter():F2}";
    }
}
