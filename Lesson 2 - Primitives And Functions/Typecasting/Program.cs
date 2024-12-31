// Warm-up exercise:
// Write a function that takes a number and returns the Square of that number ( n^2 )

// Type Casting
// When you assign a data type to another type, such as converting a char
// to an int to get the ascii value.
// 0 - 255
// implicit cast
char myChar = 'A';

object myObject = myChar;
//Console.WriteLine(myObject);

// dynamically typed lanuages (Loosely-typed)
// Javascript, Python, etc.
// let a = 30;
// function showString(a)

// Statically-Typed lanuages (Strongly-typed)
// C#, C++, Java, etc.
// [type] [name] = [value]
var myObject2 = myChar;

myChar = 'A';


// cast to ascii
//Console.WriteLine((int)myChar);

// Exercise: Write a function that PRINTS out all of the ascii codes of a given string's characters.
// Exercise: Write a function that PRINTS out the CHARACTER of a given ascii code (int)
// Exercise: Write a function that RETURNS the int value of a given boolean
// Exercise: Write a function that RETURNS a random number as a string

string myString = "Hello, World";

// Passing-by-value
string AddExclaimation(string str)
{
    return str + "!";
}

// Passing-by-reference (pointer)
// CLR - Common Lanuage Runtime (C#)
void AddExclaimation2(ref string str)
{
    str += "!";
}

Console.WriteLine(myString);
AddExclaimation2(ref myString);
Console.WriteLine(myString);
Console.ReadKey();

// Exercise: Write a function that takes a REFERENCE to
// an int and modifies it to equal a random number.
// Print the value before AND after calling the function.

string something = "";

Console.WriteLine(something + 1);