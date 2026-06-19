namespace Sim;

public class Window(int width, int height, int fps = 60)
{
    //todo: add method calculations for proper scaling

    private int _scale = Util.GCD(width, height);
    private Pair _dimensions = new(width / Util.GCD(width, height), height / Util.GCD(width, height));
    public int Width
    {
        get => _dimensions.X * _scale;
        set;
    }

    public int Height
    {
        get => _dimensions.Y * _scale;
        set;
    }

    public int FPS
    {
        get => fps;
        set;
    }
}