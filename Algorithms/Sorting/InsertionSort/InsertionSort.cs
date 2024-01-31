namespace DSA;

public static class InsertionSort
{
    public static void Main(int[] array)
    {
        for (var i = 1; i < array.Length; i++)
        {
            var temp = array[i];
            var j = i - 1;

            while (j >= 0 && array[j] > temp)
                array[j + 1] = array[j--];

            array[j + 1] = temp;
        }
    }
}
