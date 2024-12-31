// Inheiritance
// AKA Polymorphism

// Polymorphism is the usage or conversion of an
// object to utilize it as a different type

// the : operator is used to denote that we are using something
// from a parent object/type

// To inheirt a class, use the : operator followed by the class
// you want to inheirt

class Animal { }
class Dog : Animal { }
class Cat : Animal { }

// types of relationships
// is-a
// has-a

// Using variables in child classes
class Car
{
    // Declaring a variable
    // [Type] [Name] = [Assignment]
    // [Access] [Type] [Name] = [Assignment]
    public int maxSpeed; // has-a relationship

    // Private function
    void Foo()
    {
        //[Type] [Name] = [Assignment]
        // Do not need "access"
        bool canFoo = false;
    }

    // virtual keyword
    // virtual is a keyword that we can give to functions
    // to let this class know that this function should be
    // overridable in child classes
    public virtual void Ignition()
    {
        maxSpeed = 100;
        Console.WriteLine("Started Car!");
    }
}

// Honda's parent class is called Car
// Another name for a "parent class" is "base class"
class Honda : Car
{
    // override keyword
    // override is a keyword that we can give to functions
    // to let this class know that the function we have defined
    // comes from it's parent class and we want to override it.

    // overriding simply means
    // "this function definition overtakes the previous one"
    // IT DOES NOT RUN THE LOGIC FROM THE PREVIOUS FUNCTION
    public override void Ignition()
    {
        Console.WriteLine("Started Honda!");

        var speed = maxSpeed;

        // Call base class' ignition function
        // base is pretty much only used to call
        // parent functions in an overridden function
        base.Ignition();
    }
}

public class Program
{
    static int health = 100;
    static int armor = 50;

    private static void Hit(int damage)
    {
        if(damage <= 0)
        {
            return;
        }

        int armorRemaining = armor - damage;
        if (armorRemaining > 0)
        {
            armor -= damage;
        }
        else
        {
            armor = 0;
            health += armorRemaining;
            if (health < 0)
            {
                health = 0;
            }
        }
    }

    public static void Main()
    {
        Honda myHonda = new Honda();
        myHonda.Ignition();

        Console.WriteLine(myHonda.maxSpeed);
        Console.ReadKey();

        // exercise
        // Add a new variable to Player for the
        // player's "Armor" value

        // Create a new class that extends Player
        // called "TankPlayer".

        // by default, Player armor should be 30
        // by default, TankPlayer armor should be 100

        // Make "Hit" a virtual function
        // Change the logic so that when the player takes damage
        // armor should be reduced first, if there is no armor left,
        // take health instead

        // verfication:
        // Create an instance of player and tankplayer
        // apply random damage to them between 0 and 75
        // print out the resulting health

    }
}