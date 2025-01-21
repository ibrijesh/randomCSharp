namespace randomCSharp.Asynchronous;

public class Async
{
    public static async Task Run()
    {
        Console.WriteLine("Task started....");
        await Task.Delay(2000);
        Console.WriteLine("Task completed....");
        
    }
}