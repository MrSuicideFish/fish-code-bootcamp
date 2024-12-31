using GameMath.Entities;

namespace GameMath.Commands;

public class MovePlayerCommand : ICommand
{
    public CommandResult Execute(Game game, string[] args)
    {
        if (args.Length < 1)
        {
            return new CommandResult()
            {
                IsSuccess = false,
                Message = "You must provide at least 1 argument."
            };
        }

        string directionStr = args[0].ToLower();
        int count = 1;
        
        // if count string exists
        if (args.Length >= 2 && !int.TryParse(args[1], out count))
        {
            return new CommandResult()
            {
                IsSuccess = false,
                Message = "You must provide an integer."
            };
        }

        Vector2 direction = new Vector2(0, 0);
        switch (directionStr)
        {
            case "up":
                direction = new Vector2(0, 1);
                break;
            case "down":
                direction = new Vector2(0, -1);
                break;
            case "left":
                direction = new Vector2(-1, 0);
                break;
            case "right":
                direction = new Vector2(1, 0);
                break;
        }

        Vector2 playerPosition;
        if (!EntityManager.Instance.FindEntityPosition(game.Player, out playerPosition))
        {
            return new CommandResult()
            {
                IsSuccess = false,
                Message = "Failed to find player position."
            };
        }

        Vector2 destination = playerPosition;
        for (int i = 1; i <= count; i++)
        {
            Vector2 samplePos = playerPosition + (direction * i);
            if (game.Map.IsWall(samplePos))
            {
                break;
            }
            destination = samplePos;
        }

        if (!EntityManager.Instance.MoveEntity(playerPosition, destination))
        {
            return new CommandResult()
            {
                IsSuccess = false,
                Message = "Something is in the way."
            };
        }
        
        return new CommandResult()
        {
            IsSuccess = true,
            Message = $"Moved!"
        };
    }
}
