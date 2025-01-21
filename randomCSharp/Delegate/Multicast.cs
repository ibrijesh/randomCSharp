namespace randomCSharp.Delegate;

delegate void Notify();

public class Multicast
{
    public static void Run()
    {
        // Create a multicast delegate
        Notify notify = FirstNotification;
        notify += SecondNotification;
        notify += ThirdNotification;

        // Invoke the multicast delegate
        Console.WriteLine("\nInvoking multicast delegate:");
        notify();

        // Remove a method from the delegate
        notify -= SecondNotification;

        Console.WriteLine("\nAfter removing SecondNotification:");
        notify();
    }


    public static void FirstNotification()
    {
        Console.WriteLine("First notification");
    }

    public static void SecondNotification()
    {
        Console.WriteLine("Second notification");
    }

    public static void ThirdNotification()
    {
        Console.WriteLine("Third notification");
    }
}