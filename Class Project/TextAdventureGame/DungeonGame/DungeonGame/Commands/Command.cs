namespace GameMath.Commands;

public interface ICommand
{
    CommandResult Execute(Game game, string[] args);
}
