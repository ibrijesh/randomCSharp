namespace randomCSharp.Inheritance;

public class BaseClass
{
    protected string name { get; set; }

    public BaseClass(string name)
    {
        this.name = name;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"BaseClass: {name}");
    }
}