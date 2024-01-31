# Insertion Sort

Insertion sort is a simple sorting algorithm that builds the final sorted array one item at a time. It is an in-place comparison-based algorithm that works by dividing the input array into a sorted and an unsorted region. It repeatedly takes the next element from the unsorted region and inserts it into the correct position in the sorted region.

## Algorithm

The algorithm for insertion sort can be summarized as follows:

1. Start with the second element (key) in the array.
2. Compare the key with the elements before it in the sorted region.
3. If the key is smaller, shift the elements in the sorted region to the right until the correct position for the key is found.
4. Insert the key into the correct position in the sorted region.
5. Repeat steps 2-4 for the remaining elements in the unsorted region.

## Time Complexity

The time complexity of insertion sort is O(n^2) in the worst case, where n is the number of elements in the array. This occurs when the input array is in reverse order, and each element needs to be compared with all the previous elements in the sorted region.

In the best case, when the input array is already sorted, the time complexity of insertion sort is O(n). This occurs when each element only needs to be compared with the previous element in the sorted region.

## Space Complexity

The space complexity of insertion sort is O(1) because it only requires a constant amount of additional space to store the key and perform the swaps.
