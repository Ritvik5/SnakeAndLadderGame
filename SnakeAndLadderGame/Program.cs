namespace SnakeAndLadderGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Game\n");

            int position = 0;
            int playerOne;
            playerOne = position;
            Console.WriteLine("Position of PlayerOne is : " + playerOne +"\n");

            Random random = new Random();
            int rollsDice = random.Next(0, 7);
            Console.WriteLine("Rolled Dice number is : " +rollsDice +"\n");
        }
    }
}