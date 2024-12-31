using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Making a game
// This game is a alien invaders clone
// a lot of things in the game behave or react
// in similar ways with interfaces, we can define these behvaiors

// Damageables have similar behavior
// they can all be hit and presumably have
// a health pool.
// 
// Interfaces have the ability to grant us decoupling for these

public interface IMoveable
{
    bool CanMove { get; set; }
    float PositionX { get; set; }
    float PositionY { get; set; }
    float MoveSpeed { get; set; }

    void Move(float x, float y);
}

public interface IDamageable
{
    int Health { get; }
    void Hit(int damage);

    // Sometimes interfaces can not only define a property
    // but also give it an implmentation
    // Note: But only do this if all inheiritors can share the implementation
    bool IsDead
    {
        get
        {
            return Health <= 0;
        }
    }
}

public interface IDoDamage
{
    int AttackDamage { get; }

    int AttackRange { get; }
}

// The implementation of an IDamageable interface
public class Asteroid : IDamageable, IDoDamage
{
    // Implicitly
    public int Health { get; private set; }

    // Optional, based on need.
    // Explicitly
    int IDamageable.Health { get; }

    public bool IsDead { get; private set; }

    // Function implmentations must be "public"
    // Implicitly
    public void Hit(int damage)
    {
        // Animation to break up
        // glows
    }

    // Explicitly
    void IDamageable.Hit(int damage) { 
        
    }

    // Implement IDoDamage

    // Implicit
    int AttackDamage { get; set; }
    int AttackRange { get; set; } // Asteroids have reach, bro!


    // Explicit
    int IDoDamage.AttackDamage { get; }
    int IDoDamage.AttackRange { get; }

    public Asteroid()
    {
        // We can set default values in our implemention
        // in  constructors!

        // This is how your set implicit properties
        AttackDamage = 100;

        // This is how you set explicit properties
        // The logic on this line, casts the current object
        // as an IDoDamage before calling AttackDamage.
        // 
        // When the reciever (Asteroid) gets the request,
        // it will be doing so (explicitly) as an IDoDamage
        // instead of as an Astroid.
        // This is C# 7.0 and below
        //((IDoDamage)this).AttackDamage = AttackDamage;
    }
}

