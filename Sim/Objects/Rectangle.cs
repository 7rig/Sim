using System.Drawing;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using Color = Raylib_cs.Color;

namespace Sim.Objects;

public class Rectangle(int x, int y, int w, int h, Color color)
{
    private Pair _origin = new(x, y);
    private Pair _dimensions = new(w, h);
    
    //todo: add method to calculate corners
    
    public int OriginX
    {
        get => _origin.X;
        set => _origin.X = Math.Abs(value);
    }

    public int OriginY
    {
        get => _origin.Y;
        set => _origin.Y = Math.Abs(value);
    }

    public int Width
    {
        get => _dimensions.X;
        set => _dimensions.X = Math.Abs(value);
    }

    public int Height
    {
        get => _dimensions.Y;
        set => _dimensions.Y = Math.Abs(value);
    }

    public void Draw()
    {
        DrawRectangle(OriginX, OriginY, Width, Height, color);
    }

    public void Move()
    {
        //todo: implement
    }
}