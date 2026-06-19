using Raylib_cs;

namespace Sim.Instances;

public class TestInstance : Instance
{
    private string _msg = "Ticks elapsed: 0";
    
    public override Window Initialize()
    {
        return new Window(new(16, 9), 30);
    }

    public override void Update(uint dt)
    {
        _msg = $"Ticks elapsed: {dt}";
    }

    public override void Draw()
    {
        Raylib.DrawText(_msg, 10, 10, 40, Color.White);
    }
}