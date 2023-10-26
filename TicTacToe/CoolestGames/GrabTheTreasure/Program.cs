using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Grab the Treasure!");
            bool playAgain = true;

            while (playAgain)
            {
                PlayGame();
                Console.Write("Do you want to play again? (yes/no): ");
                string playAgainInput = Console.ReadLine().ToLower();
                if(playAgainInput == "yes") { playAgain = true; }
                   else { playAgain = false; }
            }
        }

        static void PlayGame()
        {
            char[,] Map = new char[10, 10] {
                { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_'},
                { '|', '$', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', '_', '_', '_', '_', '_', '_', '_', '_', '|'}
            };

            int[] HeroPos = { 3, 1 }; // Initial position of the hero
            int[] EnemyPos = { 3, 5 }; // Initial position of the enemy

            Console.WriteLine("Name of player: ");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                name = "Player 1";
            }

            bool gameOver = false;
            bool hasTreasure = false;

            while (!gameOver)
            {
                DisplayMap(Map);
                Console.WriteLine($"\n{name}, enter your move (1 - up, 2 - down, 3 - left, 4 - right): ");
                string input = Console.ReadKey().KeyChar.ToString();
                int move;

                if (int.TryParse(input, out move))
                {
                    int[] newHeroPos = MoveHero(HeroPos, move);
                    if (IsMoveLegal(newHeroPos, Map))
                    {
                        Map[HeroPos[0], HeroPos[1]] = ' ';
                        HeroPos = newHeroPos;
                        Map[HeroPos[0], HeroPos[1]] = 'H';

                        // Check if hero grabbed the treasure
                        if (HeroPos[0] == 1 && HeroPos[1] == 1)
                        {
                            hasTreasure = true;
                        }

                        // Move enemy randomly
                        Map[HeroPos[0], HeroPos[1]] = ' ';
                        EnemyPos = MoveEnemy(EnemyPos, Map);
                        Map[EnemyPos[0], EnemyPos[1]] = 'E';

                        // Check if hero touched the enemy
                        if (HeroPos[0] == EnemyPos[0] && HeroPos[1] == EnemyPos[1])
                        {
                            gameOver = true;
                            Console.WriteLine("\nGame Over! You were caught by the enemy.");
                        }

                        // Check if hero escaped with the treasure
                        if (hasTreasure && HeroPos[0] == 0 && HeroPos[1] == 9)
                        {
                            gameOver = true;
                            Console.WriteLine($"\nCongratulations, {name}! You escaped with the treasure!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid move. The spot is inaccessible. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a number between 1 and 4.");
                }
            }
        }

        static void DisplayMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }

        static int[] MoveHero(int[] currentPosition, int move)
        {
            int[] newPosition = { currentPosition[0], currentPosition[1] };

            switch (move)
            {
                case 1: // Up
                    newPosition[0]--;
                    break;
                case 2: // Down
                    newPosition[0]++;
                    break;
                case 3: // Left
                    newPosition[1]--;
                    break;
                case 4: // Right
                    newPosition[1]++;
                    break;
            }

            return newPosition;
        }

        static int[] MoveEnemy(int[] currentPosition, char[,] map)
        {
            Random random = new Random();
            int move = random.Next(1, 5);
            int[] newPosition = { currentPosition[0], currentPosition[1] };

            // Ensure the enemy moves to an accessible position
            while (true)
            {
                newPosition = MoveHero(currentPosition, move);
                if (IsMoveLegal(newPosition, map))
                {
                    break;
                }
                move = random.Next(1, 5);
            }

            return newPosition;
        }

        static bool IsMoveLegal(int[] position, char[,] map)
        {
            int row = position[0];
            int col = position[1];

            // Check if the position is within the map boundaries
            if (row >= 0 && row < map.GetLength(0) && col >= 0 && col < map.GetLength(1))
            {
                // Check if the position is not a wall '|', '_', or an enemy 'E'
                if (map[row, col] != '|' && map[row, col] != '_' && map[row, col] != 'E')
                {
                    return true;
                }
            }

            return false;
        }
    }
}
