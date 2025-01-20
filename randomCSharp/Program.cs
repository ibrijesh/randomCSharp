using randomCSharp.Inheritance;

namespace randomCSharp;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        BaseClass baseClass = new BaseClass("BaseObject");
        baseClass.DisplayInfo();


        DerivedClass derivedClass = new DerivedClass("DerivedObject", 42);
        derivedClass.DisplayInfo();
        
        
    }
}