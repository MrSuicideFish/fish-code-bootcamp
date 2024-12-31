using GameMath.Entities;
using GameMath.Interfaces;

namespace GameMath.Enemies;

public class EnemyState_Patrol : State
{
    //Overriding a Constructor.
    public EnemyState_Patrol(IStateMachine parent) 
        : base(parent) { }
    
    public override void Draw()
    {
        Console.Write('p');
    }

    public override void Update()
    {
        if (m_parent is IEntity parent)
        {
            if (EntityManager.Instance.FindEntityPosition(parent, out Vector2 parentPosition)
                && EntityManager.Instance.FindEntityPosition(Game.Instance.Player, out Vector2 playerPosition))
            {
                //Check to see if player is nearby
                int dist = Vector2.Distance(parentPosition, playerPosition);
                if (dist <= 3)
                {
                    m_parent.SetState(new EnemyState_Chase(m_parent));
                }
                else
                {
                    Vector2 moveDir = Vector2.FromDirection((EDirection) new Random().Next(0, 4));
                    EntityManager.Instance.MoveEntity(parentPosition, parentPosition + moveDir);
                }
            }
        }
    }
}

public class EnemyState_Chase : State
{
    public EnemyState_Chase(IStateMachine parent)
        : base(parent) { }
    public override void Draw()
    {
        Console.Write('c');
    }

    public override void Update()
    {
        if (m_parent is IEntity parent)
        {
            if (EntityManager.Instance.FindEntityPosition(parent, out Vector2 parentPosition)
                && EntityManager.Instance.FindEntityPosition(Game.Instance.Player, out Vector2 playerPosition))
            {
                int dist = Vector2.Distance(parentPosition, playerPosition); 
                if (dist > 4)
                {
                    m_parent.SetState(new EnemyState_Patrol(m_parent));
                }else if (dist < 2)
                {
                    m_parent.SetState(new EnemyState_Attacking(m_parent));
                }
                else
                {
                    Vector2 dir = playerPosition - parentPosition;
                    
                    // Whichever component is the largest, only use that component
                    if (dir.x > dir.y)
                    {
                        dir.y = 0;
                    }else if (dir.y > dir.x)
                    {
                        dir.x = 0;
                    }
                    else if(dir.x == dir.y)
                    {
                        dir.y = 0;
                    }

                    // normalize the vector
                    dir.x = Math.Clamp(dir.x, -1, 1);
                    dir.y = Math.Clamp(dir.y, -1, 1);

                    if (!EntityManager.Instance.MoveEntity(parentPosition, parentPosition + dir))
                    {
                        m_parent.SetState(new EnemyState_Attacking(m_parent));
                    }
                }
            }
        }
    }
}

public class EnemyState_Attacking : State
{
    public EnemyState_Attacking(IStateMachine parent)
        : base(parent) { }
    
    public override void Draw()
    {
        Console.Write('a');
    }

    public override void Update()
    {
        if (m_parent is Enemy parent)
        {
            if (EntityManager.Instance.FindEntityPosition(parent, out Vector2 parentPosition)
                && EntityManager.Instance.FindEntityPosition(Game.Instance.Player, out Vector2 playerPosition))
            {
                int dist = Vector2.Distance(parentPosition, playerPosition);
                if (dist >= 3)
                {
                    m_parent.SetState(new EnemyState_Chase(m_parent));
                    return;
                }

                if (Game.Instance.Player.IsDead)
                {
                    m_parent.SetState(new EnemyState_Patrol(m_parent));
                    return;
                }
                
                int damage = parent.Stats.Attack;
                Game.Instance.Player.Hit(damage, killImmediately: false);
            }
        }
    }
}