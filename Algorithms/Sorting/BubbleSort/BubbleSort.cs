namespace DSA;

public static class BubbleSort
{
    public static void Main(int[] input)
    {
        for (var i = 0; i < input.Length - 1; i++)
        {
            for (var j = 0; j < input.Length - i - 1; j++)
            {
                if (input[j] > input[j + 1])
                {
                    (input[j + 1], input[j]) = (input[j], input[j + 1]);
                }
            }
        }
    }
}
