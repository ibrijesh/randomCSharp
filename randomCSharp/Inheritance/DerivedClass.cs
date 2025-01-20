namespace randomCSharp.Inheritance;

public class DerivedClass : BaseClass
{
    private int DerivedValue { get; set; }

    public DerivedClass(string name, int value) : base(name)
    {
        DerivedValue = value;
    }

    public void DerivedDisplay()
    {
        Console.WriteLine($"Derived Display: {name}, {DerivedValue}");
    }
}