// Exercise:
/*
 *
 * Exercise: Write a function that copies this source array to the destination array
 * Both arrays should be the same size
 *
*/

// Lesson - Non-primitive types, Classes

//primitve types
using System.Runtime.CompilerServices;

int a;
string b;
bool c;
object o;

// non-primitives
// classes
// structs
// interfaces

int foo = 3;

// classes
// Defining a class
// [Access] class [ClassName]
//public class MyClass
//{

//}

// Defining type of class
// [Access] [Type] class [ClassName]

// Types
// Static
// Abstract
// Sealed
// Etc.

// Declaring a new variable with a class-type
MyClass myVar;

// when initializing non-primive types
// we use () because the constructor is a function
// And when calling functions, you always use ().
myVar = new MyClass("","","");

Console.WriteLine(myVar);
Console.WriteLine(myVar.ToString());
Console.WriteLine(sizeof(int));
Console.WriteLine(sizeof(bool));
Console.WriteLine(sizeof(int) + sizeof(bool));
Console.ReadKey();

// Write a new class called "Phone" that
// contains a function called "Call" that takes
// an int as a phone number.

// Then, call the new function with a random number
// that is 7 digits


// Challenge 1
// Create variable and set it's value to your name.

// Challenge 2
// Create a function that takes two numbers and returns the sum

// Challenge 3
// Create a function the takes 3 strings and returns the sum (concatenation)
// separated by a semicolon.