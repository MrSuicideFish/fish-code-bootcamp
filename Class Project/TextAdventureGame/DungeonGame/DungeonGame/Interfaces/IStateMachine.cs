using GameMath.Enemies;

namespace GameMath.Interfaces;

public interface IStateMachine
{
    void SetState(State newState);
   
   
}

public abstract class State
{
    protected IStateMachine m_parent;
    public State(IStateMachine parent)
    {
        m_parent = parent;
    }
   
    public abstract void Draw();
    public abstract void Update();
}