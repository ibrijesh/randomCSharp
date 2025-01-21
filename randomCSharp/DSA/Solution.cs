namespace randomCSharp.DSA;

public class Solution
{
    public static List<string> fruits = new List<string>();
    public static List<KeyValuePair<string, int>> fruitsWithValue = new List<KeyValuePair<string, int>>();


    static Solution()
    {
        fruits =
        [
            "apple", "mango", "banana", "pineapple",
            "mango", "banana", "apple", "mango"
        ];

        fruitsWithValue = new List<KeyValuePair<string, int>>()
        {
            new KeyValuePair<string, int>("apple", 1),
            new KeyValuePair<string, int>("mango", 2),
            new KeyValuePair<string, int>("banana", 3),
            new KeyValuePair<string, int>("apple", 3),
            new KeyValuePair<string, int>("mango", 5),
            new KeyValuePair<string, int>("banana", 2)
        };
    }


    public static Dictionary<string, int> CountFruits(ref List<KeyValuePair<string, int>> list)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach (var (key, value) in list)
        {
            if (result.ContainsKey(key))
            {
                result[key] += value;
            }
            else
                result[key] = value;
        }

        return result;
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

    public static void PrintListwithKeyValue(Dictionary<string, int> list)
    {
        foreach (var (key, value) in list)
        {
            Console.WriteLine(key + " : " + value);
        }
    }
}