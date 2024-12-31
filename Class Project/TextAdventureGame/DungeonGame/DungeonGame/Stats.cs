namespace GameMath;

public struct Stats
{
    public int Level;
    public int Experience;
    public int ExperienceToNextLevel;
    public int Health;
    public int Gold;
    public int Attack;

    public override string ToString()
    {
        return $"Level: {Level}\n"
               + $"Experience: {Experience}\n"
               + $"Health: {Health}\n"
               + $"Gold: {Gold}\n"
               + $"Attack: {Attack}\n";
    }

    public static Stats operator +(Stats a, Stats b)
    {
        Stats result = new Stats();
        result.Level = a.Level + b.Level;
        result.Experience = a.Experience + b.Experience;
        result.ExperienceToNextLevel = a.ExperienceToNextLevel + b.ExperienceToNextLevel;
        result.Health = a.Health + b.Health;
        result.Gold = a.Gold + b.Gold;
        result.Attack = a.Attack + b.Attack;
        return result;
    }
}
