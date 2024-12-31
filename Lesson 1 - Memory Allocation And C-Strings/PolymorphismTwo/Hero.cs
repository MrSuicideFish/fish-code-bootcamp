using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IHero : IDamageable, IDoDamage
{
    public string Name { get; }

    public void Attack(IDamageable dmgable);
}

public class Tracer : IHero
{
    public string Name { get; private set; }

    public int Health { get; private set; }

    public int AttackDamage { get; private set; }
    public int AttackRange { get; private set; }

    // property / Accessor
    public bool IsDead
    {
        get
        {
            return Health <= 0;
        }
    }

    public Tracer()
    {
        Name = "Tracer";
        Health = 100;
        AttackDamage = 10;
        AttackRange = 40;
    }

    public void Attack(IDamageable dmgable)
    {
        // check distance
        // if dist is close enough
        // then attack dmgable
        int distance = 5;
        if(distance <= AttackRange)
        {
            dmgable.Hit(AttackDamage);
        }
    }

    public void Hit(int damage)
    {
        Health -= damage;
    }
}

public class Winton : IHero
{
    public string Name { get; private set; }

    public int Health { get; private set; }

    public int AttackDamage { get; private set; }
    public int AttackRange { get; private set; }

    public bool IsDead
    {
        get
        {
            return Health <= 0;
        }
    }

    public Winton()
    {
        Name = "Winton";
        Health = 100;
        AttackDamage = 10;
        AttackRange = 40;
    }

    public void Attack(IDamageable dmgable)
    {
        // check distance
        // if dist is close enough
        // then attack dmgable
        int distance = 5;
        if (distance <= AttackRange)
        {
            dmgable.Hit(AttackDamage);
        }
    }

    public void Hit(int damage)
    {
        Health -= damage;
    }
}