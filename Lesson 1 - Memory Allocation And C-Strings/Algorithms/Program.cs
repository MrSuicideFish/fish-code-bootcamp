using System;
// Algorithms

// Types of algos
//
// Sorting
// Searching
// Optimization
// Graphing

// Sorting
// Types of sorting
// --
// In-place sorting: Re-organizing a single array
// 
// Stable sorting: Grabbing a chunk of sorted data
// Unstable Sorting: Nothing in order, do one by one.

// Measuring / Telemetry
//
// Time Complexity: How fast an algo is
// Space Complexity: How much space/memory an algo takes up
// Big-O Notation: The format in which we describe time/space complexity
//
// Example: Classroom of 100 students. You give your pencil to one,
// then have to find who has it.

// O(n): Asking each student one-by-one
// O(n^2): Ask the first person in the class if they have the pen. Also,
//          you ask this person about the other 99 people if they have that
//          pen and so on.
//
// O(log n): Divide the class into two groups, then ask is it
//          on the left side or right side? Then you take group and
//          divide it again and repeat.
//
// Formal defintion of Big-O:
// f(N)=O(g(N)), if pos constants C,
//              N0 such that f(N) <= c * g(N) for all N >= N0
//
//

// Quicksort
// Time-Complexity = O(n log n)
// 
void Quicksort(int[] array, int left, int right)
{
    var i = left;
    var j = right;
    var pivot = array[left];

    while(i < j)
    {
        while(array[i] < pivot)
        {
            i++;
        }

        while (array[j] < pivot)
        {
            j--;
        }

        if(i <= j)
        {
            // do swap
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }

        if(left < j)
        {
            // do a swap
            Quicksort(array, left, j);
        }

        if(i < right)
        {
            // do a swap
            Quicksort(array, i, right);
        }
    }
}

// Bubble Sort
// Time complexity: O()

// {5, 7, 3, 1, 0, 6, 9, 8, 4, 2}
// {5, 3, 1, 0, 6, 7, 8, 4, 2, 9}
// {5, 3, 1, 0, 6, 7, 8, 4, 2, 9}
// {5, 3, 1, 0, 6, 7, 8, 4, 2, 9}
// {5, 3, 1, 0, 6, 7, 8, 4, 2, 9}
// {5, 3, 1, 0, 6, 7, 8, 4, 2, 9}
// {5, 3, 1, 0, 6, 7, 8, 4, 2, 9}
// {5, 3, 1, 0, 6, 7, 8, 4, 2, 9}
// {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
// {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
void BubbleSort(int[] array)
{
    int temp;
    int swaps = 0;
    for(int i = 0; i <= array.Length-2; i++)
    {
        // check if the current element is greater than the last one
        // if it is, swap the elements
        if (array[i] > array[i+1])
        {
            temp = array[i+1];
            array[i+1] = array[i];
            array[i] = temp;
            swaps++;
        }
    }

    if (swaps > 0)
    {
        BubbleSort(array);
    }
}