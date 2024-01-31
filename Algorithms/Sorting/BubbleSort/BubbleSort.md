# Bubble Sort

Bubble sort is a simple comparison-based sorting algorithm. It repeatedly steps through the list, compares adjacent elements, and swaps them if they are in the wrong order. This process is repeated until the entire list is sorted.

## Algorithm

1. Start at the beginning of the list.
2. Compare the first and second elements. If they are in the wrong order, swap them.
3. Move to the next pair of elements and repeat step 2.
4. Continue this process until the end of the list is reached.
5. If any swaps were made in the previous pass, repeat steps 1-4. Otherwise, the list is sorted.

## Time Complexity

- Best Case: O(n)
  - The best case occurs when the list is already sorted. In this case, bubble sort only needs to make a single pass through the list to confirm that it is sorted.
- Worst Case: O(n^2)
  - The worst case occurs when the list is in reverse order. In this case, bubble sort needs to make n-1 passes through the list, each time comparing and swapping adjacent elements.

## Space Complexity

Bubble sort has a space complexity of O(1) because it only requires a constant amount of additional space to store temporary variables used for swapping elements.
