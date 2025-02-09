using System.Diagnostics;

namespace randomCSharp.MultiThread;

public class MultiThreadParallel
{
    public static void HeavyComputation()
    {
        double sum = 0;

        for (int i = 0; i < 1_000_000_00; ++i)
            sum += Math.Sqrt(i);
    }

    public static void Main()
    {
        Stopwatch sw = new Stopwatch();

        // Sequential Execution 
        sw.Start();
        for (int i = 0; i < 10; ++i) HeavyComputation();
        sw.Stop();
        Console.WriteLine($"Sequential Time: {sw.ElapsedMilliseconds} ms");

        // Parallel execution
        sw.Restart();
        Parallel.For(0, 10, _ => HeavyComputation());
        sw.Stop();
        Console.WriteLine($"Parallel Time: {sw.ElapsedMilliseconds} ms");
    }
}