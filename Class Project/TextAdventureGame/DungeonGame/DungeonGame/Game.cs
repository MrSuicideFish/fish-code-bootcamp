using GameMath;
using GameMath.Commands;
using GameMath.Entities;

public class Game
{
    public static Game Instance { get; private set; }
    
    private CommandService m_commandService;
    private HistoryService m_historyService;
    
    public Player Player { get; private set; } 
    public bool GameIsOver { get; private set; }
    public Map Map { get; private set; }
    public HistoryService HistoryService => m_historyService;
    
    public Game()
    {
        Instance = this;
        m_commandService = new CommandService();
        m_historyService = new HistoryService();
        Map = new Map("EnemyRoom");
        Player = new Player();
        EntityManager.Instance.AddEntity(Map.StartPosition, Player);
    }

    public bool Update()
    {
        EntityManager.Instance.Update();
        if (Player.IsDead)
        {
            GameIsOver = true;
            m_historyService.AddHistory("Player is dead");
            return false;
        }
        return true;
    }
    
    public void Draw()
    {
        Console.Clear();
        
        // draw the map
        Map.Draw();
        
        // draw the chat history
        m_historyService.Draw();
    }

    public bool Submit(string command, string[] args)
    {
        string commandHistory = string.Join(" ", new string[] {command, string.Join(" ", args)});
        m_historyService.AddHistory(commandHistory);
        CommandResult result = m_commandService.TryExecuteCommand(this, command, args); 
        m_historyService.AddHistory(result.Message);
        return result.IsSuccess;
    }
}
