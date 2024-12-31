
using MathPractice;

public class Program
{
    public static void Main(string[] args)
    {
        // positions
        Vector2 squarePos = new Vector2();
        squarePos.x = 0;
        squarePos.y = 0;
        
        Vector2 circlePos = new Vector2();
        circlePos.x = 2;
        circlePos.y = 0;
        
        // getting the distance between the two vectors
        // Distance = d = sqrt((x1 - x0)^2 + (y1 - y0)^2)
        double distance = Math.Sqrt(
            Math.Pow(circlePos.x - squarePos.x, 2) 
            + Math.Pow(circlePos.y - squarePos.y, 2));
        
        System.Console.WriteLine(distance);
        
        // move circle and square up by 5 units, and to the left by 3 units
        // v = (-3, 5)
        Vector2 moveVector = new Vector2(-3, 5);
        
        // add the move vector to our two objects
        circlePos += moveVector;
        squarePos -= moveVector;
        
        // scalar multiplication
        // Multiplying a vector by a single results in a longer vector
        squarePos += moveVector * 3;

        int speed = 10;
        squarePos += moveVector * speed;
        
        // dot product
        // Mulitplying a vector by another vector will rotate the vector
        
        Console.WriteLine(squarePos);
        Console.WriteLine(circlePos);
    }
}