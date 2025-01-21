using randomCSharp.Asynchronous;
using randomCSharp.Delegate;
using randomCSharp.Inheritance;

namespace randomCSharp;

public class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello World");

        BaseClass baseClass = new BaseClass("BaseObject");
        baseClass.ShowMessage();


        DerivedClass derivedClass = new DerivedClass("DerivedObject", 42);
        derivedClass.ShowMessage();


        BaseClass derivedClass2 = new DerivedClass("DerivedObject2", 55);
        derivedClass2.ShowMessage();

        Random.Learn();
        EmployeeLogic.Run();
        Multicast.Run();

        Console.WriteLine("Start");
        await Async.Run(); // Async method call
        Console.WriteLine("End");
    }
}