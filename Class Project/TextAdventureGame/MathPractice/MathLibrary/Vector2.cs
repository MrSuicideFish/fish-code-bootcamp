namespace MathPractice;

public class Vector2
{
    public int x;
    public int y;

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
}