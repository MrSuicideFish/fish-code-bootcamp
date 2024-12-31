
// We went over the entry point of a C# program
// Create class for your program

// Exercise:
/*
 * Write a program that takes two arguments for it's executable (exe):
 *   Word (s):
 *       Where s contains only: a-z, A-Z, 0-1
 *   Number (n):
 *       Where 0 > n < 100
 *
 *   The program should then print Word N times.
 *   Be sure to handle possible edge cases:
 *       Invalid number of arguments
 *       invalid characters in s
 *       n is incorrect type
 *       n is invalid
 */
public class Program
{

    static int atoi(string s)
    {
        int result = 0;
        for(int i = 0; i < s.Length; ++i)
        {
            if(s[i] <= '0' || s[i] >= '9')
            {
                return 0;
            }

            result = result * 10 + s[i] - '0';
        }
        return result;
    }

    // Create an entry point function for our program
    public static void Main(string[] args)
    {
        
    }

    // Write a program that queries/manages for players.
    // Your program should contain the following functions:
    // 
    // Player GetPlayerById(int id) - Return the player with the given ID
    // bool AddPlayer(string displayName) - Add a new player to the collection with the given displayName and ID set appropriately
    // void ListAllPlayers() - Should print out the display name and ID of each player. E.g: Mr.Fish (28182890382)
}