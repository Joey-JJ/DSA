namespace DSA;

public static class MergeSortImplementation
{
    public static int[] MergeSort(int[] array)
    {
        if (array.Length <= 1) return array;

        var middleIndex = array.Length / 2;
        var left = array[0..middleIndex];
        var right = array[middleIndex..];

        var sortedLeft = MergeSort(left);
        var sortedRight = MergeSort(right);

        return Merge(sortedLeft, sortedRight);
    }

    private static int[] Merge(int[] left, int[] right)
    {
        List<int> result = [];
        var leftIndex = 0;
        var rightIndex = 0;

        while (leftIndex < left.Length && rightIndex < right.Length)
        {
            if (left[leftIndex] < right[rightIndex])
                result.Add(left[leftIndex++]);
            else
                result.Add(right[rightIndex++]);
        }

        while (leftIndex < left.Length)
            result.Add(left[leftIndex++]);

        while (rightIndex < right.Length)
            result.Add(right[rightIndex++]);

        return [.. result];
    }
}
