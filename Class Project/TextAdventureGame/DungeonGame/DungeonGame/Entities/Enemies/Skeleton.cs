using GameMath.Entities;
using GameMath.Interfaces;

namespace GameMath.Enemies;

public class Skeleton : Enemy
{
    public Skeleton()
    {
        this.Stats = new Stats()
        {
            Level = 1,
            Health = 2,
            Attack  = 3,
            Gold = 500
        };
        
        SetState(new EnemyState_Patrol(this));
    }
}
