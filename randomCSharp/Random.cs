namespace randomCSharp;

public class Random
{
    public static void Learn()
    {
        // Array
        int[] array = new int[4];

        array[0] = 47;
        array[1] = 77;
        array[2] = 87;
        array[3] = 97;

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}