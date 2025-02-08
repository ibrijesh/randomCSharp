using randomCSharp.Asynchronous;
using randomCSharp.Delegate;
using randomCSharp.DSA;
using randomCSharp.Inheritance;

namespace randomCSharp;

public class Program
{
    static async Task Mains(string[] args)
    {
        Console.WriteLine("Hello World");

        BaseClass baseClass = new BaseClass("BaseObject");
        baseClass.ShowMessage();


        DerivedClass derivedClass = new DerivedClass("DerivedObject", 42);
        derivedClass.ShowMessage();


        BaseClass derivedClass2 = new DerivedClass("DerivedObject2", 55);
        derivedClass2.ShowMessage();

        // Random.Learn();
        // EmployeeLogic.Run();
        // Multicast.Run();

        // Console.WriteLine("Start");
        // await Async.Run(); // Async method call
        // Console.WriteLine("End");


        //Solution.PrintList(Solution.CountFrequencyOfFruits(ref Solution.fruits));

        //Solution.PrintListwithKeyValue(Solution.CountFruits(ref Solution.fruitsWithValue));

        //MultiThread.MultiThread.Run();
        
        

        //await Task.WhenAll(Async.doSomethingAsync(), Async.doSomethingAsync());
    }
}