namespace Sim;

public static class Util
{
    public static int GCD(int a, int b)
    {
        // thanks to Drew Noakes
        // https://stackoverflow.com/a/41766138
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        return a | b;
    }
}