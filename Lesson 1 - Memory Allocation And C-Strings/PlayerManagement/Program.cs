
// create a new cs file.
// Define a new class called Player
// Give it private variables for
// Name, Health, Mana, Stamina

// Give Player a function called Hit
// That removes a given amount of health

Player p = new Player();
p.Hit(50);

// Lesson: We have a group of players
// in our game and we need to manage them
//
// Basically, manage a collection (array)
// of players.

// Create an array of players
// [Type] [Name] = [Assignment]

Player[] guild = new Player[0];

// Create a function to add a player
void AddPlayer(Player newPlayer)
{
    var result = new Player[guild.Length+1];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = guild[i];
    }
    result[result.Length-1] = newPlayer;
}

// Create a function that creates AND adds
// a new player

// -Heap-
// Operating system
// Application
// Function
// --const variable
// --const variable

void CreatePlayer(string playerName)
{
    const int defaultMana = 100;
    const int defaultStamina = 100;

    // Create a new instance of a player
    Player newPlayer = new Player();

    // Set the name of the new instance
    newPlayer.SetName(playerName);

    // Give the player default values
    newPlayer.SetMana(defaultMana);
    newPlayer.SetStamina(defaultStamina);

    // Add that new instance to the collection
    AddPlayer(newPlayer);
}

//AddPlayer(new Player("Carmen"));
//AddPlayer(new Player());
//AddPlayer(new Player());
//AddPlayer(new Player());
//AddPlayer(new Player());
//CreatePlayer("Mr.Fish");

// Value Types vs Reference Types
int foo = 32;
bool b = false;
Player somePlayer = new Player();

// Variables of a reference type
// store REFERENCES to their data (object)
Console.WriteLine(somePlayer);

// Variables of a value type
// directly contain their data
Console.WriteLine(foo);

void ChangeValueType(int something)
{
    something = 30;
}

void ChangeMe(Player player)
{
    player.Name = "Test";
}

ChangeValueType(foo);
ChangeMe(somePlayer);
Console.WriteLine(foo);
Console.WriteLine(somePlayer.Name);

// write a for-loop that
// prints out the name of each player
for (int i = 0; i < guild.Length; i++)
{
    Console.WriteLine(guild[i]);
}
Console.ReadKey();


// Exercise:
// Create a function that chooses a random player
// from our collection, and deals a random amount of damage
// print out the health of each player

// Note: Make sure all players start with 100 Health
void DoRandomDamage()
{
    
}