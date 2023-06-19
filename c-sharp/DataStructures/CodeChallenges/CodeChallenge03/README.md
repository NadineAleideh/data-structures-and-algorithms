# Code challenge03: array binary search

Writing a function called BinarySearch that takes in 2 parameters: a sorted array, the search key and returns the index of the array’s element that is equal to the value of the search key, or -1 if the element is not in the array. Without using any of the built-in methods in C#.

## Whiteboard Process

![whiteboard1](./CodeChallenge3p1.jpg)
![whiteboard2](./CodeChallenge3p2.jpg)
![whiteboard2](./CodeChallenge3p3.jpg)

## Approach & Efficiency

1. Check if the input array is null. If it is, throw exception.

2. Check if the input array is sorted. If it is not, throw exception.

3. Initialize variables: L = 0, H = length of the array - 1.

4. Loop until H is grater than or equal to L:

- Calculate the middle index: m = (L + H) / 2 and floor it .
- If the value at the middle index is equal to the search key, return the middle index.
- If the value at the middle index is less than the search key, update L to m + 1.
- If the value at the middle index is greater than the search key, update H to m - 1.

5. If the loop finishes without finding the search key, return -1.

- time complexity O(log n)  in both average and worst because it divides the search space in half at each step. and O(1) in the best case when the middle  element is equal to the value of the search key so we don't need looping.

- space complexity O(1) because a constant space requires.

## Solution

```

public static int BinarySearch(int[] arr, int key)
{
   
    if (arr == null)
    {
        throw new Exception("Input array cannot be null.");
    }

    if (!IsArraySorted(array))
    {
        throw new Exception("Input array must be sorted .");
    }

    int L = 0;
    int H = arr.Length - 1;

    while (H >= L)
    {
        int m = (L + H) / 2;

        if (arr[m] == key)
        {
            return m;
        }
        else if (arr[m] < key)
        {
            L = m + 1;
        }
        else
        {
            H = m - 1;
        }
    }

    return -1;
}

public static bool IsArraySorted(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[i - 1])
        {
            return false;
        }
    }

```

## How to run

In the Main method do the following:

```

int[] arr = { 4, 8, 15, 16, 23, 42 };
int key = 15;

try
{
    int index = BinarySearch(arr, key);
    Console.WriteLine(index);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

```

