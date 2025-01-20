using randomCSharp.Inheritance;

namespace randomCSharp;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        BaseClass baseClass = new BaseClass("BaseObject");
        baseClass.ShowMessage();


        DerivedClass derivedClass = new DerivedClass("DerivedObject", 42);
        derivedClass.ShowMessage();


        BaseClass derivedClass2 = new DerivedClass("DerivedObject2", 55);
        derivedClass2.ShowMessage();

        Random.Learn();
    }
}