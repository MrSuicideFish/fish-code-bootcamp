/*
 * Write a calculator program that takes 3 arguments for it's executable (exe):
     FirstNumber (N0)
     SecondNumber (N1)
     Operator (o):
 	  Plus, Minus, Divide, Multiply.
 
 The program should then do the arithmetic determined by the operator.
 */

public class Program
{
    public static void Main(string[] args)
    {
        // -Lists-
        // Arrays aren't resizable
        int[] f = new int[10];

        // Lists are basically resizable arrays
        List<int> listF = new List<int>();
        listF.Add(1);
        listF.Remove(1);
        
        // C# - Generics
        // They are a way to introduce type-casting into object creation
        // List<int> -- the <> symbols indicates the type of objects in the list
        
        if(f.Length == 0)
        {
            
        }

        if(listF.Count == 0)
        {

        }
    }
}

// Exercise
//
// Write a program that holds information of up to 5 usernames
// The program should recieve a userName and add it to the list/collection.
// if the list is full (length == 5) then return "is full" message
// otherwise return the following:
//  Length == 1 : "First House"
//  Length == 2 : "Second Car"
//  Length == 3 : "Third Bike"
//  Length == 4 : "Forth Rocket"
//  Length == 5 : "Usernames are full!"

// ./program MrFish
