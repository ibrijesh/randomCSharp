namespace randomCSharp.Asynchronous;

public class Async
{
    public static async Task Run()
    {
        Console.WriteLine("Task started....");
        Task task1 = Task.Delay(1000);
        Task task2 = Task.Delay(2000);
        
        await Task.WhenAll(task1, task2); // Waits for both tasks to complete
        Console.WriteLine("Both tasks completed");
        Console.WriteLine("Task completed....");
        
    }
}