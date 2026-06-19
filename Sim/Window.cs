namespace Sim;

public class Window(Pair ratio, int scale, int fps = 60)
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

    public int FPS
    {
        get => fps;
        set;
    }
}