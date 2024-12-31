// exercise: Write a function that takes a player and returns
// true if the player is dead or false if the player is still alive
// be sure to test it by printing out the player health
// (outside of the function call)

// Access Modifiers
// public
// private
// protected -  Only used in places
//              where you need child classes to have
//              access to this thing

// Composition (Wide)
// We are building pieces that are on the same "logical" layer
// For example, adding variables and functions to Player

// Inheiritance & Polymorphism (Deep)
// We are building pieces that further define new layers
// For example, TankPlayer is-a Player, so a new layer is defined

// Terminal
// Navigate to your "bin" folder under your project directory.
// Navigate to Debug/net x.0/
// This is your project's exe directory
// First, build our project

public class Program
{
    // static variable
    // on the heap
    private static bool isDebugMode = false;

    // Program entry point
    // Arguments passed to this entry point come from the OS
    // Note:
    // Be mindful of the format that the string comes in. (leading dashes)

    // Static - Our program's entry-point exists on the heap

    static int[] NameToChar(string arg)
    {
        int[] result = new int[arg.Length];
        for (int i = 0; i < arg.Length; i++)
        {
            char c = arg[i];
            result[i] = (int)arg[i];
        }
        return result;
    }

    public static void Main(string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            int[] stringAsChar = NameToChar(args[i]);
            for (int j = 0; j < stringAsChar.Length; j++)
            {
                Console.WriteLine(stringAsChar[j]);
            }
        }
    }
}