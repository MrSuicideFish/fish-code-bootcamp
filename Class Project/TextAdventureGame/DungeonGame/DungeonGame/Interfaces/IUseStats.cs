namespace GameMath.Interfaces;

public interface IUseStats
{
    Stats Stats {get;}
    void ApplyDeltaStats(Stats delta);
}
