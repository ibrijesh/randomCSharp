namespace randomCSharp.MultiThread;

public class MultiThread
{
    private static int sum = 0;


    public static void CountSum()
    {
        for (int i = 1; i <= 5; ++i)
        {
            int temp = sum;
            Thread.Sleep(1);
            sum = temp + i;  // // Simulate context switch (increases chances of race condition)
            Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}  , i = {i},  Sum = {sum}");
        }
    }


    public static void Main()
    {
        Thread thread1 = new Thread(CountSum);
        thread1.Start();


        Thread thread2 = new Thread(CountSum);
        thread2.Start();


        thread1.Join();
        thread2.Join();
        
        Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}  , Sum = {sum}");
    }
}