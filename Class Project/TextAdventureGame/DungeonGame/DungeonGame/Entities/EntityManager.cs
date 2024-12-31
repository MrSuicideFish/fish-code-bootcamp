namespace GameMath.Entities;

public class EntityManager
{
    private static EntityManager m_instance;
    public static EntityManager Instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = new EntityManager();
            }
            return m_instance;
        }
    }
    
    private Dictionary<Vector2, IEntity> m_entityData;

    private EntityManager()
    {
        m_entityData = new Dictionary<Vector2, IEntity>();
    }

    public bool AddEntity(Vector2 position, IEntity entity)
    {
        return m_entityData.TryAdd(position, entity);
    }

    public bool RemoveEntity(Vector2 position)
    {
        return m_entityData.Remove(position);
    }

    public bool FindEntityPosition(IEntity entity, out Vector2 result)
    {
        if (entity == null)
        {
            result = default;
            return false;
        }
        
        foreach (var kvp in m_entityData)
        {
            if (kvp.Value == entity)
            {
                result = kvp.Key;
                return true;
            }
        }
        
        result = default;
        return false;
    }

    public IEntity GetEntity(Vector2 position)
    {
        IEntity result = null;
        if (m_entityData.TryGetValue(position, out result))
        {
            return result;
        }
        return null;
    }

    public bool MoveEntity(Vector2 from, Vector2 to, bool forceDestroy = false)
    {
        if (from == to)
        {
            return false;
        }
        
        IEntity fromEntity = GetEntity(from);
        if (fromEntity == null)
        {
            return false;
        }
        
        IEntity toEntity = GetEntity(to);
        if (toEntity != null)
        {
            if (!forceDestroy)
            {
                return false;
            }
            
            RemoveEntity(to);
        }

        RemoveEntity(from);
        AddEntity(to, fromEntity);
        return true;
    }

    public bool TryGetEntity(Vector2 position, out IEntity entity)
    {
        return m_entityData.TryGetValue(position, out entity);
    }

    public void Update()
    {
        for (int i = 0; i < m_entityData.Values.Count; i++)
        {
            m_entityData.Values.ElementAt(i).Update();
        }
    }
}
