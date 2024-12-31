namespace GameMath;

public struct Vector2
{
    public int x;
    public int y;

    public static Vector2 Zero = new Vector2(0, 0);
    public static Vector2 Up => new Vector2(0, 1);
    public static Vector2 Down => new Vector2(0, -1);
    public static Vector2 Left => new Vector2(-1, 0);
    public static Vector2 Right => new Vector2(1, 0);

    public Vector2()
    {
        
    }
    
    public Vector2(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return $"({x}, {y})";
    }

    public static Vector2 FromDirection(EDirection direction)
    {
        switch (direction)
        {
            case EDirection.North:
                return Vector2.Up;
            case EDirection.South:
                return Vector2.Down;
            case EDirection.East:
                return Vector2.Right;
            case EDirection.West:
                return Vector2.Left;
        }
        return Vector2.Zero;
    }

    public static int Distance(Vector2 a, Vector2 b)
    {
        return Math.Abs(a.x - b.x) + Math.Abs(a.y - b.y);
    }

    // Operator overloading
    public static Vector2 operator +(Vector2 vector1, Vector2 vector2)
    {
        return new Vector2(vector1.x + vector2.x, vector1.y + vector2.y);
    }
    
    // create a function for vector subtraction
    // using operator overloading
    public static Vector2 operator -(Vector2 vector1, Vector2 vector2)
    {
        return new Vector2(vector1.x - vector2.x, vector1.y - vector2.y);
    }
    
    // Perform scalar multiplication
    public static Vector2 operator *(Vector2 vector1, int scalar)
    {
        return new Vector2(vector1.x * scalar, vector1.y * scalar);
    }
    
    public static bool operator ==(Vector2 vector1, Vector2 vector2)
    {
        return vector1.x == vector2.x
            && vector1.y == vector2.y;
    }
    
    public static bool operator !=(Vector2 vector1, Vector2 vector2)
    {
        return vector1.x != vector2.x
               || vector1.y == vector2.y;
    }
}
