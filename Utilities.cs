namespace Route_adv01;

internal class Utilities
{
    public static void Swap<T>(ref T a, T b)
    {
        T temp = a;
        a = b; 
        b = temp;
    }

    public static T FindMax<T>(T[] arr) where T : IComparable<T>
    {
        if (arr == null || arr.Length == 0)
            Console.WriteLine("array has no elemnts");
        T max = arr[0];
        foreach(var item in arr)
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }
        return max;
    }
}
