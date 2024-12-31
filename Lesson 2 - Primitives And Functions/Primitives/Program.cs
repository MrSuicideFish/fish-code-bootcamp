
// 1) Write a function that returns a random number
Random rnd = new Random();
int number = rnd.Next();

int RandomNumber()
{
  Random rnd = new Random();
  return rnd.Next(number);
}

int RandomNumberShort(){
    return new Random().Next(number);
}

int RandomNumberShortest() => new Random().Next(number);

// 2) Write a function that returns
//  true if the given string equals "Mr.Fish"
bool WhatName(string name)
{
    return name == "Mr.Fish";
}

// 3) Write a function that returns the string "True" if the GIVEN number is greater
// than (or equal to) 10 and returns the string "False" if it is less than
int x = 300;
if( x >= 10){

}

// 4) Write a function that takes two strings,
// adds them together then returns the result.
string a = "Hello,";
string b = "World!";
string c = a + b;

// 5) Write a function that returns the Nth character of the given string.
// Where n is given as well.

// 6) Write a function that prints out a number value recieved from another function
int Foo()
{
    return 232002;
}

void Bar()
{
    int number = Foo();
    Console.WriteLine(Foo());
}

// 7) Write a function that returns true if ONE of TWO other FUNCTIONS returns true
int x1 = 10;
int y1 = 20;
int x2 = 100;
int y2 = 200;
bool myBool1 = true;
bool myBool2 = true;

bool Foo2(){
    if ((myBool1 == true && myBool2 == false)
    || (myBool1 == false && myBool2 == true))
    {
        return true;
    }
    return (x1 < 100)
        && (y1 < 100)
        || (x2 >= 100)
        || (y2 >= 100)
        && myBool1 == false
        && !myBool2;
}