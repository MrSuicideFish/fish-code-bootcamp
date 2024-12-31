using GameMath;
using GameMath.Entities;
using GameMath.Interfaces;
using Vector2 = GameMath.Vector2;

public class Player : IEntity, IDamageable, IUseStats
{
    private Stats m_stats = new();
    public Stats Stats =>m_stats;
    public bool IsDead { get; private set; }
    
    public void ApplyDeltaStats(Stats delta)
    {
        m_stats += delta;
    }

    public Player()
    {
        m_stats.Level = 1;
        m_stats.Attack = 5;
        m_stats.Gold = 10;
        m_stats.Health = 10;
        m_stats.ExperienceToNextLevel = 10;
    }
        
    public void Hit(int Damage, bool killImmediately = false)
    {
        if (killImmediately)
        {
            m_stats.Health = 0;
            IsDead = true;
            return;
        }
        
        m_stats.Health -= Damage;
        if (m_stats.Health <= 0)
        {
            m_stats.Health = 0;
            IsDead = true;
        }
    }

    public void Draw()
    {
        Console.Write('x');
    }
    
    public void Update()
    {
    }

    public Vector2 GetPosition()
    {
        Vector2 result = Vector2.Zero;
        EntityManager.Instance.FindEntityPosition(this, out result);
        return result;
    }
}
