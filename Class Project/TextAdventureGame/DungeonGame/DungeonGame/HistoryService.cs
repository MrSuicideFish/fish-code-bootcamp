namespace GameMath;

public class HistoryService
{
    private const int MaxHistorySize = 10;
    private List<string> m_history;

    public HistoryService()
    {
        m_history = new List<string>();
    }

    public void AddHistory(string msg)
    {
        if (string.IsNullOrEmpty(msg))
        {
            return;
        }
        
        m_history.Add(msg);
    }
    
    public void Draw()
    {
        Console.WriteLine("--------------- HISTORY ---------------");
        for (int i = 0; i < MaxHistorySize; i++)
        {
            int idx = m_history.Count - (MaxHistorySize - i);
            if (idx < 0 || idx >= m_history.Count)
            {
                continue;
            }

            Console.WriteLine(m_history[idx]);
        }
        Console.WriteLine("---------------------------------------");
    }
}
