using GameMath.Entities;
using GameMath.Interfaces;

namespace GameMath.Enemies;

public class Enemy : IEntity, IDamageable, IUseStats, IStateMachine
{
    private Stats m_stats;

    public Stats Stats
    {
        get => m_stats;
        protected set => m_stats = value;
    }
    
    private State m_currentState;
    public bool IsDead { get; private set; }

    public void ApplyDeltaStats(Stats delta)
    {
        m_stats += delta;
    }

    public virtual void Draw()
    {
        if (m_currentState != null)
        {
            m_currentState.Draw();
        }
        else
        {
            Console.Write("e");
        }
    }

    public virtual void Update()
    {
        if (m_currentState != null)
        {
            m_currentState.Update();
        }
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

    public void SetState(State newState)
    {
        m_currentState = newState;
    }
}
