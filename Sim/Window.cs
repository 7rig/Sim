namespace Sim;

public class Window(Pair ratio, int scale, int fps = 60)
{
    //todo: replace ratio param with individual ints and set up lcd math to create a pair for ratio
    //todo: (follow pair rule for fields only)
    
    //todo: add method calculations for proper scaling
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