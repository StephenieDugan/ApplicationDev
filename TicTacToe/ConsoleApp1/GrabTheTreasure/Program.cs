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
                playAgain = playAgainInput == "yes";
            }
        }

        static void PlayGame()
        {
            char[,] aryMap = new char[7, 7] {
                { '_', '_', '_', '_', '_', '_', '_'},
                { '|', '$', ' ', ' ', ' ', ' ', '|'},
                { '|', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', 'Ȫ', ' ', ' ', ' ', ' ', ' '},
                { '|', ' ', '_', '|', ' ', ' ', '|'},
                { '|', ' ', ' ', '|', ' ', ' ', '|'},
                { '|', '_', '_', '|', '_', '_', '_'}
            };

            int[] aryHeroPos = { 3, 1 }; // Initial position of the hero
            int[] aryEnemyPos = { 3, 5 }; // Initial position of the enemy

            Console.WriteLine("Name of player: ");
            string playerName = Console.ReadLine();
            if (string.IsNullOrEmpty(playerName))
            {
                playerName = "Player 1";
            }

            bool gameOver = false;
            bool hasTreasure = false;

            while (!gameOver)
            {
                DisplayMap(aryMap);
                Console.WriteLine($"{playerName}, enter your move (1 - up, 2 - down, 3 - left, 4 - right): ");
                string input = Console.ReadKey().KeyChar.ToString();
                int move;

                if (int.TryParse(input, out move))
                {
                    int[] newHeroPos = MoveHero(aryHeroPos, move);
                    if (IsMoveLegal(newHeroPos, aryMap))
                    {
                        aryMap[aryHeroPos[0], aryHeroPos[1]] = ' ';
                        aryHeroPos = newHeroPos;
                        aryMap[aryHeroPos[0], aryHeroPos[1]] = 'H';

                        // Check if hero grabbed the treasure
                        if (aryHeroPos[0] == 1 && aryHeroPos[1] == 1)
                        {
                            hasTreasure = true;
                        }

                        // Move enemy randomly
                        aryMap[aryEnemyPos[0], aryEnemyPos[1]] = ' ';
                        aryEnemyPos = MoveEnemy(aryEnemyPos, aryMap);
                        aryMap[aryEnemyPos[0], aryEnemyPos[1]] = 'E';

                        // Check if hero touched the enemy
                        if (aryHeroPos[0] == aryEnemyPos[0] && aryHeroPos[1] == aryEnemyPos[1])
                        {
                            gameOver = true;
                            Console.WriteLine("Game Over! You were caught by the enemy.");
                        }

                        // Check if hero escaped with the treasure
                        if (hasTreasure && aryHeroPos[0] == 6 && aryHeroPos[1] == 3)
                        {
                            gameOver = true;
                            Console.WriteLine($"Congratulations, {playerName}! You escaped with the treasure!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid move. The spot is inaccessible. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
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
