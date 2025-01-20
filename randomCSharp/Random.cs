namespace randomCSharp;

public class Random
{
    public static void DisplayInfo(string name, int age, string city)
    {
        Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
    }

    public static void Learn()
    {
        // Using named parameters to pass arguments in any order
        DisplayInfo(age: 30, name: "Alice", city: "New York");

        // You can still call it using positional arguments if needed
        DisplayInfo("Bob", 25, "Los Angeles");
    }
}