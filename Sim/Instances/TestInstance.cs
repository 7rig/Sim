using Raylib_cs;

namespace Sim.Instances;

public class TestInstance : Instance
{
    private string _msg = "Secs elapsed: 0";
    private Objects.Rectangle _rect = new(100, 100, 100, 50, Color.White);
    
    public override Window Initialize()
    {
        return new Window(960, 540);
    }

    public override void Update(uint dt)
    {
        _msg = $"Secs elapsed: {dt / InstanceWindow.FPS}";
    }

    public override void Draw()
    {
        Raylib.DrawText(_msg, 10, 10, 40, Color.White);
        _rect.Draw();
    }
}