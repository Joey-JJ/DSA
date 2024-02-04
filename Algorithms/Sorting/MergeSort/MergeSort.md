# Merge Sort

Merge sort is a divide-and-conquer algorithm that sorts an array by dividing it into two halves, sorting each half separately, and then merging the sorted halves. It is a stable sorting algorithm, meaning that the relative order of equal elements is preserved.

## Algorithm

The merge sort algorithm can be described in the following steps:

1. Divide the unsorted array into two halves.
2. Recursively sort each half.
3. Merge the two sorted halves to produce the sorted array.

## Time Complexity

- Best Case: O(n log n)
- Average Case: O(n log n)
- Worst Case: O(n log n)

The time complexity of merge sort is consistent regardless of the input data. It always divides the array into two halves and recursively sorts them, resulting in a time complexity of O(n log n).

## Space Complexity

Merge sort has a space complexity of O(n) because it requires additional space to store the merged subarrays during the merging phase. This additional space is proportional to the size of the input array.

## Upsides

- Stable sorting: Merge sort preserves the relative order of equal elements, making it suitable for sorting objects with multiple keys.
- Consistent performance: Merge sort has a consistent time complexity of O(n log n) regardless of the input data, making it a reliable choice for large datasets.

## Downside

- Space complexity: Merge sort requires additional space to store the merged subarrays, which can be a concern for large arrays with limited memory.
