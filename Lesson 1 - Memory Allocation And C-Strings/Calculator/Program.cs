
// Exercise
// Write a calculator program (no-gui required) that takes 3 arguments
// for its executable:

// FirstNumber (N1)
// SecondNumber (N2)
// Operator (o)

// The user should input the 3 args when calling the program
// Afterwards, the program should do
// the designated arithmetic on the numbers determined by
// the operator.

// Make sure your progam gracefully handles unexpected inputs

// ./MyCalculator 330 100 +
// output: 430

// Switch Statements
// Sometimes we want check for a large number of conditonals. This is where switch
// statements come in. It takes a single value, then compares that value to each CASE
// defined in the statement
/*
int number = 0;

// dont do this
if(number == 0){ }
if(number == 1){ }
if(number == 2){ }
if(number == 0 || number == 1 || number == 2) {}

// instead, do this

// switch takes the value you want to compare to each case
// NOTE: The cursor (when program is running) doesn't visit each case!
// It skips the the case that matches, if no case matches and there is no default
// case. The entire switch state is skipped.
switch(number)
{
    case 2:
        Console.WriteLine("Number is 2!");
        break;
    case 10:
        Console.WriteLine("Number is 10!");
        break;

    // optionally, you can add a default case, in the event that none of the cases
    // are a match
    default:
        Console.WriteLine("No case found for number!");
        break;
}

// resolves as string
var variable1 = "+"; // e.g. string variable1 = "+";

// resolves as a char
var variable2 = '+'; // e.g. char variable2 = '+';
*/