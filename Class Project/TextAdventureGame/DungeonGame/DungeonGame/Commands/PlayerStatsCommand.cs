namespace GameMath.Commands;

public class PlayerStatsCommand : ICommand
{
    public CommandResult Execute(Game game, string[] args)
    {
        foreach (string line in game.Player.Stats.ToString().Split('\n'))
        {
            game.HistoryService.AddHistory(line);
        }
        
        return new CommandResult()
        {
            IsSuccess = true
        };
    }
}
