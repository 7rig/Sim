using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace Sim;

public abstract class Instance
{
    private uint _dt;
    private Window _window;
    public Window InstanceWindow { get => _window; set; }
    
    public abstract Window Initialize();
    public abstract void Update(uint dt);
    public abstract void Draw();

    public Instance()
    {
        _window = Initialize();
        _dt = 0;
        
        InitWindow(_window.Width, _window.Height, "Program");
        SetTargetFPS(_window.FPS);

        while (!WindowShouldClose())
        {
            Update(_dt);
            
            BeginDrawing();
            ClearBackground(Black);
            Draw();
            EndDrawing();

            _dt++;
        }
        CloseWindow();
    }
}