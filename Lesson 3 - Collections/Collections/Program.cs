
// Lesson - Collections (C#)
// Arrays, Lists, Dictionaries<KvP>, Hashset

// Declaring an array variable (or a variale in general)
// [datatype][] [variableName]
// Note: the []'s after variable type are only to declare that the variable is an array.
// Note: Do not put the size here!
using System.Reflection;

string[] myStringsArray;

// Initialize an array variable
myStringsArray = new string[3];

// Setting the value of an array index
// Note: In other words, a location in memory within our array's block
myStringsArray[0] = "Mr.Fish";
myStringsArray[1] = "Mr.Spaghetti";
myStringsArray[2] = "Peeley";

// Doing declarion, initialization, and setting values at the same time
string[] myStringsArray2 = new string[] { "", "", "" };

// Getting values from the array
void PrintStrings(string[] strs)
{
    for (int i = 0; i < strs.Length; i++)
    {
        Console.WriteLine(strs[i]);
    }
}

// Exercise: Declare an array of int's with 30 indicies and set all indicies to '15'.
PrintStrings(myStringsArray);

bool[] boolArray = new bool[5];
// Arrays start uninitialized
// Note: Or in other words, defaulted-by-type.
// 0 - uninitialized
// 1 - uninitialized
// 2 - uninitialized
// 3 - uninitialized
// 4 - uninitialized

// For bool arrays
// 0 - False
// 1 - False
// 2 - False
// 3 - False
// 4 - False

int[] intArray = new int[5];
// For int arrays
// 0 - 0
// 1 - 0
// 2 - 0
// 3 - 0
// 4 - 0

// "Pointer" to bool array that doesn't point to anything yet
bool[] uninitializedArray;


// Resizing
int[] array1 = new int[5];

array1[0] = 15;
array1[1] = 15;
array1[2] = 15;
array1[3] = 15;
array1[4] = 15;

// add one more?
// This won't work!
array1[5] = 15;

// How to resize
int[] newArray = new int[6];
for (int i = 0; i < array1.Length; i++)
{
    newArray[i] = array1[i];
}

newArray[5] = 15;

// Using a function to resize
int[] ResizeArray(int[] array, int newSize)
{
    int[] result = new int[newSize];
    for (int i = 0; i < result.Length; i++)
    {
        if (i >= array.Length)
        {
            break;
        }

        result[i] = array[i];
    }
    return result;
}

newArray = ResizeArray(newArray, newArray.Length * 2);

// Quick quiz - The function above 'ResizeArray' has a huge problem. What is it?

// Resize in place
void ResizeArrayInPlace(ref int[] array, int newSize)
{
    int[] bufferArray = array;
    array = new int[newSize];
    for (int i = 0; i < bufferArray.Length; i++)
    {
        if (i >= bufferArray.Length)
        {
            break;
        }

        array[i] = bufferArray[i];
    }
}

//ResizeArrayInPlace(ref array1, newArray.Length * 2);
string[] source = new string[] { "One", "Two", "Three" };
string[] destination = new string[] { "Four", "Five", "Six" };

// Function CopyArray(int[] source, int[] destination)


// Write a function that copies a
// "source" array to a "destination" array.
// You may assume that both arrays are guaranteed to be the same size,
// so no size check is needed.

// Test 1
for (int i = 0; i < destination.Length; i++)
{
    Console.WriteLine(destination[i]);
}

// C# has useful functions!
Array.Copy(source, destination, source.Length);
Array.Resize(ref source, source.Length * 10);

// Exercise
// Write a function that returns the result of joining together 2 int arrays
// Note: The result should be a new array that is the combination of both arrays.

// mathematically:
//      x = y
//      y = x - 6
//      x - 6 = y
//      ?

string[] result = new string[source.Length + destination.Length];
for (int i = 0; i < source.Length + destination.Length; i++)
{
    if(i < source.Length){
        result[i] = source[i];
    }else{
        result[i] = destination[i-source.Length];
    }
}

Console.ReadKey();