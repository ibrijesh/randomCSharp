namespace randomCSharp.MultiThread;

public class MultiThreadParallel
{
    private static int sum = 0;
    private static object lockObj = new Object();


    public static void CountSum()
    {
        for (int i = 1; i <= 5; ++i)
        {
            lock (lockObj) // Ensures thread safety while updating sum
            {
                int temp = sum;
                Thread.Sleep(1);
                sum = temp + i;
                Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}  , i = {i},  Sum = {sum}");
            }
        }
    }

    public static void Main()
    {
        Parallel.Invoke(CountSum, CountSum);
        
        Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}  , Sum = {sum}");
    }
}