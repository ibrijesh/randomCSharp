namespace randomCSharp.Delegate;

//  public delegate void Action<T1, T2, ..., T16>(T1 arg1, T2 arg2, ..., T16 arg16);

public class Multicast
{
    public static void Run()
    {
        Predicate<int> isEven = (x) => x % 2 == 0;
        Console.WriteLine(isEven(4));

        Predicate<string> startsWithA = (str) => str.StartsWith("A");
        Console.WriteLine(startsWithA("Ameer"));
    }
}