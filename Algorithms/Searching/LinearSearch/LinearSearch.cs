namespace DSA;

public static class LinearSearch
{
    public static bool Main(int[] array, int target)
    {
        for (var i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
                return true;
        }

        return false;
    }
}
