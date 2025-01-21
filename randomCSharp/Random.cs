using System.Collections;

namespace randomCSharp;

public class Random
{
    static void Increment(ref int number)
    {
        number++;
    }

    static void CalculateSum(int a, int b, out int sum)
    {
        sum = a + b;
    }


    public static void Learn()
    {
        // Array List
        ArrayList arrayList = new ArrayList();

        arrayList.Add("Ajay");
        arrayList.Add("Ankit");
        arrayList.Add(10);
        arrayList.Add(10.10);


        for (int i = 0; i < arrayList.Count; i++)
        {
            Console.WriteLine(arrayList[i]);
        }

        int result;
        CalculateSum(3, 5, out result);
        Console.WriteLine(result);
    }
}