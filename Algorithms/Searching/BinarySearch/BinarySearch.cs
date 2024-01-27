namespace DSA.Algorithms.Searching;

public static class BinarySearch
{
    public static bool BinarySearchIterative(int[] array, int target)
    {
        var left = 0;
        var right = array.Length - 1;

        while (left <= right)
        {
            var pivot = (left + right) / 2;

            if (array[pivot] == target)
                return true;
            else if (array[pivot] < target)
                left = pivot + 1;
            else
                right = pivot - 1;
        }

        return false;
    }

    public static bool BinarySearchRecursive(int[] array, int target, int start, int end)
    {
        if (start > end || array.Length == 0) return false;

        var pivot = (start + end) / 2;

        if (array[pivot] == target)
            return true;
        else if (array[pivot] > target)
            return BinarySearchRecursive(array, target, start, pivot - 1);
        else
            return BinarySearchRecursive(array, target, pivot + 1, end);
    }
}
