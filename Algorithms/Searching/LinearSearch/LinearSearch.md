# Linear Search

Linear search, also known as sequential search, is a simple searching algorithm that sequentially checks each element in a list until a match is found or the end of the list is reached. It is applicable to both sorted and unsorted lists.

## Algorithm

The linear search algorithm works as follows:

1. Start at the beginning of the list.
2. Compare the target element with the current element.
3. If a match is found, return the index of the element.
4. If the end of the list is reached without finding a match, return -1.

## Complexity Analysis

- Best Case Time Complexity: O(1)
  - The best case occurs when the target element is found at the first position of the list. In this case, only one comparison is needed.
- Worst Case Time Complexity: O(n)
  - The worst case occurs when the target element is not present in the list or is present at the last position. In this case, the algorithm needs to compare the target element with each element in the list.
- Average Case Time Complexity: O(n)
  - The average case time complexity is also O(n) because, on average, the algorithm needs to check half of the elements in the list.
- Space Complexity: O(1)
  - Linear search has a constant space complexity as it only requires a few variables to store the current element and the target element.

## Usage

Linear search is a basic and straightforward algorithm that can be used in various scenarios, such as:

- Searching for an element in an unsorted list.
- Determining if an element exists in a list.
- Finding the first occurrence of an element in a list.

It is important to note that linear search is not efficient for large lists, as its time complexity is linear. In such cases, more advanced search algorithms like binary search or hash-based search algorithms should be considered.
