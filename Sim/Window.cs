namespace Sim;

public class Window(Pair ratio, int scale)
{
    public int Width
    {
        get => ratio.X * scale;
        set;
    }

    public int Height
    {
        get => ratio.Y * scale;
        set;
    }
}