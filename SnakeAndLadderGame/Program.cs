namespace SnakeAndLadderGame
{
    public class Program
    {
        public const int IS_NO_PLAY = 0;
        public const int IS_LADDER = 1;
        public const int IS_SNAKE = 2;
        public static int RollDice()
        {
            Random random = new Random();
            int rollDice = random.Next(1, 7);
            Console.WriteLine("Rolled Dice number is " + rollDice);
            return rollDice;
        }
        public static int CheckSnake(int position)
        {
            switch (position)
            {
                case 28:
                    position = 10;
                    break;
                case 37:
                    position = 3;
                    break;
                case 47:
                    position = 16;
                    break;
                case 75:
                    position = 32;
                    break;
                case 94:
                    position = 71;
                    break;
                case 96:
                    position = 42;
                    break;
            }
            return position;
        }

        public static int CheckLadder(int position)
        {
            switch (position)
            {
                case 4:
                    position = 56;
                    break;
                case 12:
                    position = 50;
                    break;
                case 14:
                    position = 55;
                    break;
                case 22:
                    position = 58;
                    break;
                case 41:
                    position = 79;
                    break;
                case 54:
                    position = 88;
                    break;
            }
            return position;
        }

        public static bool CheckWin(int position)
        {
            return position == 100;
        }

        public static int CheckNoPlay(int previousPosition, int newDice)
        {
            int newPosition = previousPosition + newDice;
            Console.WriteLine("New position is " + newPosition);
            if (newPosition <= 100)
            {
                return newPosition;
            }
            else
            {
                return previousPosition;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Game\n");

            int position = 0;
            while (true)
            {
                int dice = RollDice();
                
                Random random = new Random();
                int options = random.Next(0,3);

                switch (options)
                {
                    case IS_NO_PLAY:
                        position = CheckNoPlay(position, dice);
                        if (CheckWin(position))
                        {
                            Console.WriteLine("You won");
                            return;
                        }
                        break;
                    case IS_LADDER:
                        Console.WriteLine("Position Before Snake and Ladder is " + position);
                        position = CheckLadder(position);
                        Console.WriteLine("Position After Snake and Ladder is " + position);
                        break;
                    case IS_SNAKE:
                        Console.WriteLine("Position Before Snake and Ladder is " + position);
                        position = CheckLadder(position);
                        Console.WriteLine("Position After Snake and Ladder is " + position);
                        break;  
                }
            }
        }
    }
}