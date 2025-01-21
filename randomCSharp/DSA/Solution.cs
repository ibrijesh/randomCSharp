namespace randomCSharp.DSA;

public class Solution
{
    public static List<string> fruits = new List<string>();


    static Solution()
    {
        fruits =
        [
            "apple", "mango", "banana", "pineapple",
            "mango", "banana", "apple", "mango"
        ];
    }

    public static List<string> CountFrequencyOfFruits(ref List<string> fruits)
    {
        List<string> uniqueFruits = new List<string>();
        Dictionary<string, bool> _hash = new Dictionary<string, bool>();

        foreach (var fruit in fruits)
        {
            if (_hash.ContainsKey(fruit))
                uniqueFruits.Add(fruit);
            else
                _hash.Add(fruit, true);
        }

        return uniqueFruits;
    }

    public static void PrintList(List<string> list)
    {
        foreach (var fruit in list)
        {
            Console.WriteLine(fruit);
        }
    }
}