
//string userInput = Console.ReadLine();
using System.Text;
using System.Xml;

int idx = 0;
while (true)
{
    Console.WriteLine("Hello! What is your name?");
    string userName = Console.ReadLine();
    switch (++idx)
    {
        case 0:
            Console.WriteLine("Hello " + userName + ", what are you doing?");
            break;
        case 1:
            Console.WriteLine($"Bonjourno! {userName}, what are you doing?");
            break;
        case 2:
            // C# StringBuilder
            // Used to build very large strings
            StringBuilder sb = new StringBuilder();

            // Same line
            sb.Append("Hello,");
            sb.Append("World!");
            sb.Append("\n");

            // Append on a new line
            sb.AppendLine("Hello, World!");

            Console.WriteLine(sb.ToString());
            break;
    }
}

// Exercise
// Ask the user for their age. If they are under 18, say you aren't allowed in. Otherwise, say welcome.
// This is the landing page for our pornsite.
string input = Console.ReadLine();

if(!string.IsNullOrEmpty(input))
{
    return;
}

int age = 0;
if(!int.TryParse(input, out age))
{
    return;
}

if(age <= 0)
{
    return;
}

if(age < 18)
{
    return;
}

Console.WriteLine("Welcome!");


// Exercise
// Given a string, write a function that returns true if
// the given string has a valid number of parenthesis.
// With valid open and closing parenth.

string foo = "(abc)"; // valid
string foo2 = "abc)"; // invalid
string foo3 = "(abc)(defg))))("; //invalid
string foo4 = "(abc)(d(efg))"; // valid
bool HasValidParenthesis(string input)
{
    return false; // return false if parenthesis are invalid
    return true; // return true if parenthesis are valid
}


// bank terminal
// 1 - search for cat
// 2 - add cat
// 3 - remove cat
string userInput = Console.ReadLine();

// Polymorphism & Inheiritance
// Inheiriting a class creates tight "coupling"
// To decouple this, we are using an interface that
// guarantees inheiriters implement their contents

public class Animal
{
    private string Name { get; set; }
    protected string SomethingThatOnlyMattersToTheBaseClass { get; set; }
}

public interface IAnimal
{
    public string Name { get; set; }
    public string Species { get; set; }
}

public class Cat : IAnimal
{
    public string Name { get; set; }
    public string Species { get; set; }
}

public class Dog : IAnimal
{
    public string Name { get; set; }
    public string Species { get; set; }
}


public class CatDatabase
{

}