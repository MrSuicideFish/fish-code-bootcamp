// Classes are automatically
// considered reference types
public class Player
{
    public string Name;
    protected int Health;
    private int Mana;
    private int Stamina;

    public Player()
    {
        Name = "Unnamed Player";
        Health = 100;
        Mana = 100;
        Stamina = 100;
    }

    public Player(string playerName)
    {
        Name = playerName;
        Health = 100;
        Mana = 100;
        Stamina = 100;
    }

    public Player(string playerName, int health)
    {
        Name = playerName;
        Health = health;
        Mana = 100;
        Stamina = 100;
    }

    public virtual void Hit(int damage)
    {
        Health -= damage;
    }

    // Create Getters and Setters 
    // For our private variables
    public void SetName(string newName)
    {
        Name = newName;
    }

    // Create a new function that returns
    // The player's name
    public string GetName()
    {
        return Name;
    }

    public int GetHealth()
    {
        return Health;
    }

    public int GetMana()
    {
        return Mana;
    }

    public void SetMana(int mana)
    {
        Mana = mana;
    }

    public int GetStamina()
    {
        return Stamina;
    }

    public void SetStamina(int stamina)
    {
        Stamina = stamina;
    }

    public bool IsDead()
    {
        return Health <= 0;
    }
}