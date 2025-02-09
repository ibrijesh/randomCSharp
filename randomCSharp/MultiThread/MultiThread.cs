using System.Diagnostics;

namespace randomCSharp.MultiThread;

public class MultiThread
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
                sum = temp + i; // // Simulate context switch (increases chances of race condition)
                Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}  , i = {i},  Sum = {sum}");
            }
        }
    }


    public static void Main()
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        
        Thread thread1 = new Thread(CountSum);
        thread1.Start();


        Thread thread2 = new Thread(CountSum);
        thread2.Start();


        thread1.Join();
        thread2.Join();
        
        sw.Stop();

        Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}  , Sum = {sum}");
        
        Console.WriteLine($"Total time taken {sw.ElapsedMilliseconds} ms.");
    }
}