namespace GameMath.Commands;

public class CommandService
{
    private Dictionary<string, ICommand> m_commands;

    public CommandService()
    {
        m_commands = new Dictionary<string, ICommand>()
        {
            { "teleport", new TeleportPlayerCommand() },
            { "move", new MovePlayerCommand() },
            { "stats", new PlayerStatsCommand()}
        };
    }
    
    public CommandResult TryExecuteCommand(Game game, string command, string[] args)
    {
        CommandResult result = new CommandResult();
        if (!m_commands.ContainsKey(command.ToLower()))
        {
            result.IsSuccess = false;
            result.Message = $"Command '{command}' not found!";
            return result;
        }

        ICommand cmd = m_commands[command];
        result = cmd.Execute(game, args);
        if (!result.IsSuccess)
        {
            result.Message = $"{command}: {result.Message}";
        }
        return result;
    }
}
