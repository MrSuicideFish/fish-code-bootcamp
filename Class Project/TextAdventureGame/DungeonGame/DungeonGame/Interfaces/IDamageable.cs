namespace GameMath.Interfaces;

public interface IDamageable
{
    bool IsDead { get; }
    void Hit(int Damage, bool killImmediately = false);
}
