namespace randomCSharp.Delegate;

//  public delegate void Action<T1, T2, ..., T16>(T1 arg1, T2 arg2, ..., T16 arg16);

public class Multicast
{
    public static void Run()
    {
        Action action = () => Console.WriteLine("Action Delegate is called!");
        action();
        
        Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
        greet("Alice"); // Output: Hello, Alice!
        
        Action<int, int> add = (a, b) => Console.WriteLine(a + b);
        add(5, 7); // Output: 12
    }
}