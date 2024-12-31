using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rocket : IMoveable, IDamageable
{
    public int Health { get; set; }
    public bool CanMove { get; set; }
    public float PositionX { get; set; }
    public float PositionY { get; set; }
    public float MoveSpeed { get; set; }

    public void Hit(int damage)
    {
        Health -= damage;
    }

    public void Move(float x, float y)
    {
        PositionX += x;
        PositionY += y;
    }
}
