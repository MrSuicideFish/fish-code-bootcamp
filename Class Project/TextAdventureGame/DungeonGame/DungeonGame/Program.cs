public class Program
{
    private static Game m_game;
    
    public static void Main(string[] args)
    {
        m_game = new Game();
        
        // Game-Loop
        while (!m_game.GameIsOver)
        {
            m_game.Draw();
            string command = Console.ReadLine();
            string[] tokens = command.Split(' ');

            command = tokens[0];
            string[] commandArgs = tokens.Skip(1).ToArray();

            if (!m_game.Submit(command, commandArgs))
            {
                Console.WriteLine("Command Failed");
            }
            
            if (!m_game.Update())
            {
                // the game has ended on this frame
            }
        }
        
        Console.WriteLine("Game Over");
        Console.ReadLine();
    }
}
