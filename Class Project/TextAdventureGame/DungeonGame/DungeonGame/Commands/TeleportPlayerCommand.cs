namespace GameMath.Commands;

public class TeleportPlayerCommand : ICommand
{
    public CommandResult Execute(Game game, string[] args)
    {
        CommandResult result = new CommandResult();
        
        if (args.Length < 2)
        {
            result.IsSuccess = false;
            result.Message = "You must provide at least 2 arguments";
            return result;
        }

        int x = 0;
        int y = 0;

        if (!int.TryParse(args[0], out x))
        {
            result.IsSuccess = false;
            result.Message = "First argument must be a number";
            return result;
        }

        if (!int.TryParse(args[1], out y))
        {
            result.IsSuccess = false;
            result.Message = "Second argument must be a number";
            return result;
        }

        Vector2 destination = new Vector2(x, y);
        
        // check for wall before moving player
        if (game.Map.IsWall(destination))
        {
            result.IsSuccess = false;
            result.Message = "This is a wall!";
            return result;
        }
        
        //game.Player.Position = destination;
        result.IsSuccess = true;
        result.Message = $"Teleported to {destination.ToString()}";
        return result;
    }
}
