using GameMath;
using GameMath.Enemies;
using GameMath.Entities;

public class Map
{
    private static Map m_instance;
    public static Map Instance
    {
        get => m_instance;
    }
    
    private char[,] m_mapData;
    public char[,] MapData
    {
        get { return m_mapData; }
    }
    
    public Vector2 StartPosition { get; private set; }
    public bool InvertY { get; set; } = true;

    public char SamplePosition(Vector2 position)
    {
        if (position.x < 0 || position.y < 0
                           || position.x >= m_mapData.GetLength(0)
                           || position.y >= m_mapData.GetLength(1))
        {
            return char.MinValue;
        }

        return Char.ToUpper(m_mapData[position.x, position.y]);
    }

    public void Insert(Vector2 position, char data)
    {
        if (position.x < 0 || position.y < 0
                           || position.x >= m_mapData.GetLength(0)
                           || position.y >= m_mapData.GetLength(1))
        {
            return;
        }

        if (data == char.MinValue || data == char.MaxValue)
        {
            return;
        }
        
        m_mapData[position.x, position.y] = data;
    }
    
    public bool IsWall(Vector2 samplePos)
    {
        if (samplePos.x < 0
            || samplePos.y < 0 
            || samplePos.x >= MapData.GetLength(0) 
            || samplePos.y >= MapData.GetLength(1))
        {
            return true;
        }

        char c = SamplePosition(samplePos);
        return char.ToUpper(c) == '*';
    }
    
    public void Draw()
    {
        for (int y = MapData.GetLength(1)-1; y >= 0; y--)
        {
            for (int x = 0; x < MapData.GetLength(0); x++)
            {
                Vector2 coord = new Vector2(x, y);

                if (EntityManager.Instance.TryGetEntity(coord, out IEntity entity))
                {
                    entity.Draw();
                }
                else
                {
                    Console.Write(SamplePosition(coord));
                }
            }

            Console.Write('\n');
        }
    }
    public Map(string mapName)
    {
        m_instance = this;
        StartPosition = new Vector2(0, 0);
        string path = Path.Combine(
            Environment.CurrentDirectory, "Maps", $"{mapName}.txt");
        if (!File.Exists(path))
        {
            return;
        }

        string contents = File.ReadAllText(path).ToUpper();
        List<List<char>> newData = new List<List<char>>();
        int posX = 0;
        int posY = 0;
        int widestX = 0;
        string[] lines = contents.Split("\r\n");
        
        foreach(string line in lines)
        {
            posX = 0;
            List<char> row = new List<char>();
            foreach (char letter in line)
            {
                row.Add(letter);
                posX++;
                if (posX > widestX)
                {
                    widestX = posX;
                }
            }

            posY++;
            newData.Add(row);
        }
        
        m_mapData = new char[widestX, newData.Count];
        for (int y = m_mapData.GetLength(1)-1; y >= 0; y--)
        {
            for (int x = 0; x < m_mapData.GetLength(0); x++)
            {
                int newY = y;

                if (InvertY)
                {
                    newY = 0 + ((m_mapData.GetLength(1) - 1) - y);
                }
                
                if (x >= newData[newY].Count)
                {
                    continue;
                }
                
                char data = newData[newY][x];
                char lower = char.ToLower(data);
                
                if (lower == 'p')
                {
                    StartPosition = new Vector2(x, y);
                    m_mapData[x, y] = ' ';
                }
                else if (lower >= '0' && lower <= '9')
                {
                    Enemy newEnemy = EnemyFactory.CreateEnemy<Enemy>(lower);
                    if (newEnemy != null)
                    {
                        EntityManager.Instance.AddEntity(new Vector2(x, y), newEnemy);
                    }
                    
                    m_mapData[x, y] = ' ';
                }
                else
                {
                    m_mapData[x, y] = data;
                }
            }
        }
    }


}
