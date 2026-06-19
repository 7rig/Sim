using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace Sim;

public abstract class Instance
{
    private uint _dt;
    private Window _window;
    
    public abstract Window Initialize();
    public abstract void Update(uint dt);
    public abstract void Draw();

    public Instance()
    {
        _window = Initialize();
        _dt = 0;
        
        InitWindow(_window.Width, _window.Height, "Program");
        SetTargetFPS(60);

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