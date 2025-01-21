namespace randomCSharp.Delegate;

delegate int Calculation(int x, int y);

public class Multicast
{
    public static void Run()
    {
        // Create Multicast delegate
        Calculation calc = Add;
        calc += Multiply;

        // Invoke the delegate
        int result = calc(5, 10);

        Console.WriteLine($"Result of last invoked method: {result}");
    }

    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Multiply(int x, int y)
    {
        return x * y;
    }
}