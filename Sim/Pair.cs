namespace Sim;

public struct Pair(int x, int y)
{
    // a pair is for field use only, properties should never be pairs
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
}