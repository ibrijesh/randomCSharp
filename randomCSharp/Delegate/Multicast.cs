namespace randomCSharp.Delegate;

//  public delegate void Action<T1, T2, ..., T16>(T1 arg1, T2 arg2, ..., T16 arg16);

public class Multicast
{
    public static void Run()
    {
        Func<int, int, int> multiply = (a, b) => a * b;
        Console.WriteLine(multiply(3, 5));

        Func<int, int, int, int> add = (a, b, c) => a + b + c;
        Console.WriteLine(multiply(2, 3));
    }
}