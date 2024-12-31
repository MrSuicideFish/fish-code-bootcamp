// Switch / Loops

// Switch([Value_to_compare])
//{
//  case [value]:
//      break;
//  default:
//      // do this if no other case matches
//      break;

string enemyType = "TankEnemy";
string GetEnemyType() { return enemyType; }

switch(GetEnemyType())
{
    case "HealerEnemy":
        break;
    case "TankEnemy":
        // going to do this
        break;
    default:
        // No matches
        break;
}

// Loops
// for([variable]; [conditional]; [expression])
// while([conditional])
for(int i = -10; i >= -100; i--)
{

}

// Exercise
// Write a function that returns a grade as a string.
// The function should take an integer and determine what grade
// you should get.
//
// 0-4 = F
// 5 = D
// 6 = C
// 7-8 = B
// 9 = A
// 10 = A+