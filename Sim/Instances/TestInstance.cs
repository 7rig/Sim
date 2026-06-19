using Raylib_cs;

namespace Sim.Instances;

public class TestInstance : Instance
{
    private string _msg = "Secs elapsed: 0";
    
    public override Window Initialize()
    {
        return new Window(new(16, 9), 60);
    }

    public override void Update(uint dt)
    {
        _msg = $"Secs elapsed: {dt / InstanceWindow.FPS}";
    }

    public override void Draw()
    {
        Raylib.DrawText(_msg, 10, 10, 40, Color.White);
    }
}