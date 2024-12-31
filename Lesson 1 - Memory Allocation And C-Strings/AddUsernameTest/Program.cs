


// Example Inputs/Outputs
/*
 * ./MyProgam fred jane 5 john
 * 
 * Output:
 *      fred 1
 *      jane 6
 *      john 1
 *      
 * ./MyProgram fred 2 3 jane 5 john
 * 
 * Output:
 *      fred 6
 *      jane 6
 *      john 1
 */

// Conditionals
// if x == true AND y == true (&&)
// if x == true OR y == true (||)

// Equality
// if x EQUALS true (==)
// if x NOT EQUALS true (!=)

// Bitwise
// Conditionals
// & - AND (A & B = 12, 0000 1100)
// | - AND (A | B = 61, 0011 1101)
// ^ - AND (A | B = 61, 0011 1101)
// ~ - AND (A | B = 61, 0011 1101)
// << - AND (A | B = 61, 0011 1101)
// >> - AND (A | B = 61, 0011 1101)

// Test - Add Usernames To Collection
// Write a program that takes an unspecified number of arguments:
// username (u):
//      --String that contains only a-z A-Z 0-1, no special characters allowed
// 
// number (n):
//      --A Number that determines how many times to add the last provided username to
//      the collection.

// The program should print out each unique username followed by the number of times
// it occurs in the collection

public class Program
{
    public static bool IsValidString(string str)
    {
        bool result = true;
        string lower = str.ToLower();
        for (int i = 0; i < lower.Length; i++)
        {
            // check to see if this character is valid
            /*
            if ((str[i] <= '0' && str[i] >= '9')
            || ((str[i] <= 'a' && str[i] >= 'z'))
            || ((str[i] <= 'A' && str[i] >= 'Z')))
            {

            }
            */
            // non-inverse
            /*
            if (str[i] >= 'a' && str[i] <= 'z')
            {
                result = true;
            }
            */
            
            // inverted
            if(lower[i] < 'a' || lower[i] > 'z')
            {
                result = false;
                break;
            }
        }
        return result;
    }

    public static void AddOrCountUsername(string username)
    {
        int index = usernames.IndexOf(username);
        if (index == -1)
        {
            // Do increment
            usernameCount[index]++;
        }
        else
        {
            // Add username to the list
            usernames.Add(username);
            usernameCount.Add(int.MaxValue);
        }
    }

    static List<string> usernames = new List<string>();
    static List<int> usernameCount = new List<int>();

    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Not enough args.");
            return;
        }

        string prevUsername = "";
        for (int i = 0; i < args.Length; i++)
        {
            int number = 0;
            bool isNumber = int.TryParse(args[i], out number);
            if (!isNumber)
            {
                // Check to see if string contains invalid characters
                bool isValid = IsValidString(args[i]);
                if (isValid)
                {
                    AddOrCountUsername(args[i]);
                    prevUsername = args[i];
                }
                else
                {
                    Console.WriteLine("Invalid Characters!");
                    return;
                }
            }
            else
            {
                if(prevUsername == "")
                {
                    Console.WriteLine("Invalid Input!");
                    return;
                }

                int index = usernames.IndexOf(prevUsername);
                usernameCount[index] += number;
            }
        }

        for (int i = 0; i < usernames.Count; i++)
        {
            Console.WriteLine(usernames[i] + " " + usernameCount[i]);
        }
    }
}