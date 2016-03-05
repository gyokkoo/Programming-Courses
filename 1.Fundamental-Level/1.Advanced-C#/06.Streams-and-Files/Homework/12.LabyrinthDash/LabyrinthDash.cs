namespace _12.LabyrinthDash
{
    using System;

    public class LabyrinthDash
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[][] labyrinth = new char[n][];
            for (int i = 0; i < n; i++)
            {
                labyrinth[i] = Console.ReadLine().ToCharArray();
            }

            string commands = Console.ReadLine();
            int x = 0;
            int y = 0;
            int lives = 3;
            int movesMade = 0;
            foreach (var direction in commands)
            {
                int oldX = x;
                int oldY = y;
                switch (direction)
                {
                    case '>':
                        y++;
                        break;
                    case 'v':
                        x++;
                        break;
                    case '^':
                        x--;
                        break;
                    case '<':
                        y--;
                        break;
                }

                if (x < 0 || labyrinth.Length <= x ||
                    y < 0 || labyrinth[x].Length <= y ||
                    labyrinth[x][y] == ' ')
                {
                    movesMade++;
                    Console.WriteLine("Fell off a cliff! Game Over!");
                    break;
                }

                if (labyrinth[x][y] == '_' || labyrinth[x][y] == '|')
                {
                    Console.WriteLine("Bumped a wall.");
                    x = oldX;
                    y = oldY;
                }
                else if (labyrinth[x][y] == '@' || labyrinth[x][y] == '#' || labyrinth[x][y] == '*')
                {
                    movesMade++;
                    lives--;
                    Console.WriteLine("Ouch! That hurt! Lives left: {0}", lives);
                    if (lives == 0)
                    {
                        Console.WriteLine("No lives left! Game Over!");
                        break;
                    }
                }
                else if (labyrinth[x][y] == '$')
                {
                    movesMade++;
                    lives++;
                    labyrinth[x][y] = '.';
                    Console.WriteLine("Awesome! Lives left: {0}", lives);
                }
                else if (labyrinth[x][y] == '.')
                {
                    movesMade++;
                    Console.WriteLine("Made a move!");
                }
            }

            Console.WriteLine("Total moves made: {0}", movesMade);
        }
    }
}