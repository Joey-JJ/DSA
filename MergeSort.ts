function mergeSort(array: number[]): number[] {
    if (array.length <= 1) return array;

    const middleIndex = Math.floor(array.length / 2);
    const left = array.slice(0, middleIndex);
    const right = array.slice(middleIndex);

    const sortedLeft = mergeSort(left);
    const sortedRight = mergeSort(right);

    return merge(sortedLeft, sortedRight);
}

function merge(left: number[], right: number[]): number[] {
    const result: number[] = [];

    let leftIndex = 0;
    let rightIndex = 0;

    while (leftIndex < left.length && rightIndex < right.length) {
        if (left[leftIndex] < right[rightIndex]) {
            result.push(left[leftIndex++]);
        } else {
            result.push(right[rightIndex++]);
        }
    }

    while (leftIndex < left.length) result.push(left[leftIndex++]);
    while (rightIndex < right.length) result.push(right[rightIndex++]);

    return result;
}

function testMergeSort() {
    console.assert(
        JSON.stringify(mergeSort([4, 1, 3, 1, 54, 3, -23])) ===
            JSON.stringify([-23, 1, 1, 3, 3, 4, 54]),
        "Test 1 Failed"
    );
    console.assert(
        JSON.stringify(mergeSort([10, -1, 2, 5, 0, 6, 2, -1, -9, 11])) ===
            JSON.stringify([-9, -1, -1, 0, 2, 2, 5, 6, 10, 11]),
        "Test 2 Failed"
    );
    console.assert(
        JSON.stringify(mergeSort([3, 2, 1])) === JSON.stringify([1, 2, 3]),
        "Test 3 Failed"
    );
    console.assert(
        JSON.stringify(mergeSort([0, 0, 0, 0, 0, -1, -1, -1])) ===
            JSON.stringify([-1, -1, -1, 0, 0, 0, 0, 0]),
        "Test 4 Failed"
    );
    console.assert(
        JSON.stringify(mergeSort([])) === JSON.stringify([]),
        "Test 5 Failed"
    );
    console.assert(
        JSON.stringify(mergeSort([1])) === JSON.stringify([1]),
        "Test 6 Failed"
    );
    console.assert(
        JSON.stringify(mergeSort([2, 1])) === JSON.stringify([1, 2]),
        "Test 7 Failed"
    );
    console.assert(
        JSON.stringify(mergeSort([1, 2])) === JSON.stringify([1, 2]),
        "Test 8 Failed"
    );
}

testMergeSort();
