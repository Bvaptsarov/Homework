using System;
using System.Collections.Generic;
using System.Linq;

namespace MinesDemo
{
    public class Mines
    {
        #region Remove magic numbers.
        private const int MaxScore = 35;
        private const int NumberOfPlayers = 32; 
        private const int RowSize = 5;
        private const int ColSize = 10;
        #endregion

        private static readonly Random randomNumber = new Random();
        private static readonly List<PlayerScore> playersList = new List<PlayerScore>(NumberOfPlayers);

        static void Main(string[] args)
        {
            string input = string.Empty;
            char[,] gameField = CreateGameField();
            char[,] bombField = CreateBombField();

            int currentScore = 0; 
            int row = 0;
            int col = 0;

            bool isNewGame = true;
            bool isGameOver = false;
            bool isGameWon = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Lets play MineField, try not to hit mines" +
                                      " The command 'top' shows the players score, 'restart' - make a new game, 'exit' close the game window!");
                    DrawBoardField(gameField);
                    isNewGame = false;
                }
                
                Console.Write("Input row and col : ");
                input = Console.ReadLine().Trim();

                if (input.Length >= 3)
                {
                    if (int.TryParse(input[0].ToString(), out row) &&
                        int.TryParse(input[2].ToString(), out col) &&
                        row <= gameField.GetLength(0) && col <= gameField.GetLength(1))
                    {
                        input = "turn";
                    }
                }

                switch (input)
                {
                    case "top":
                        {
                            CreateScoreField(playersList);
                            break;
                        }
                    case "restart":
                        {
                            gameField = CreateGameField();
                            bombField = CreateBombField();
                            DrawBoardField(gameField);
                            isGameOver = false;
                            isNewGame = false;
                            break;
                        }
                    case "exit":
                        {
                            Console.WriteLine("Goodbye!");
                            break;
                        }
                    case "turn":
                        {
                            if (bombField[row, col] != '*')
                            {
                                if (bombField[row, col] == '-')
                                {
                                    CreateSurrondingEnvironment(gameField, bombField, row, col);
                                    currentScore++;
                                }

                                if (MaxScore == currentScore)
                                {
                                    isGameWon = true;
                                }
                                else
                                {
                                    DrawBoardField(gameField);
                                }
                            }
                            else
                            {
                                isGameOver = true;
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nInvalid command!\n");
                            break;
                        }
                }

                if (isGameOver)
                {
                    DrawBoardField(bombField);

                    Console.Write("\nYou died with {0} points. Please input a nickname : ", currentScore);

                    string currentNickName = Console.ReadLine();
                    PlayerScore t = new PlayerScore(currentNickName, currentScore);

                    if (playersList.Count < NumberOfPlayers)
                    {
                        playersList.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < playersList.Count; i++)
                        {
                            if (playersList[i].Score < t.Score)
                            {
                                playersList.Insert(i, t);
                                playersList.RemoveAt(playersList.Count - 1);
                                break;
                            }
                        }
                    }

                    playersList.Sort((PlayerScore firstPlayer, PlayerScore secondPlayer) =>
                        secondPlayer.Nickname.CompareTo(firstPlayer.Nickname));
                    playersList.Sort((PlayerScore firstPlayer, PlayerScore secondPlayer) =>
                        secondPlayer.Score.CompareTo(firstPlayer.Score));

                    CreateScoreField(playersList);

                    gameField = CreateGameField();
                    bombField = CreateBombField();
                    currentScore = 0;
                    isGameOver = false;
                    isNewGame = true;
                }

                if (isGameWon)
                {
                    DrawBoardField(bombField);

                    Console.WriteLine("\nCongratulations, you won!");
                    Console.WriteLine("Please input a nickname : ");

                    string currentNickName = Console.ReadLine();
                    PlayerScore currentPoints = new PlayerScore(currentNickName, currentScore);

                    playersList.Add(currentPoints);
                    CreateScoreField(playersList);

                    gameField = CreateGameField();
                    bombField = CreateBombField();
                    currentScore = 0;
                    isGameWon = false;
                    isNewGame = true;
                }
            }
            while (input != "exit");
            Console.Read();
        }

        private static void CreateScoreField(List<PlayerScore> points)
        {
            Console.WriteLine("\nScore board:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points",
                        i + 1, points[i].Nickname, points[i].Score);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There is no players in the ScoreBoard!\n");
            }
        }

        private static void CreateSurrondingEnvironment(char[,] gameField, char[,] bombField, int rowAt, int colAt)
        {
            char numberOfBombs = GetSurroundingBombCount(bombField, rowAt, colAt);
            bombField[rowAt, colAt] = numberOfBombs;
            gameField[rowAt, colAt] = numberOfBombs;
        }

        private static void DrawBoardField(char[,] board)
        {
            int rowCount = board.GetLength(0);
            int colCounts = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rowCount; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < colCounts; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = RowSize;
            int boardColumns = ColSize;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] CreateBombField()
        {
            int row = RowSize;
            int col = ColSize;
            char[,] gameField = new char[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> bombMap = new List<int>();

            while (bombMap.Count < 15)
            {               
                int location = randomNumber.Next(50);
                if (!bombMap.Contains(location))
                {
                    bombMap.Add(location);
                }
            }

            foreach (int bombLocation in bombMap)
            {
                int currCol = (bombLocation / col);
                int currRow = (bombLocation % col);

                if (currRow == 0 && bombLocation != 0)
                {
                    currCol--;
                    currRow = col;
                }
                else
                {
                    currRow++;
                }

                gameField[currCol, currRow - 1] = '*';
            }

            return gameField;
        }

        private static char GetSurroundingBombCount(char[,] gameField, int currRow, int currCol)
        {
            int bombCount = 0;

            if ((currRow - 1) >= 0)
            {
                if (gameField[currRow - 1, currCol] == '*')
                {
                    bombCount++;
                }
            }

            if ((currRow + 1) < gameField.GetLength(0))
            {
                if (gameField[currRow + 1, currCol] == '*')
                {
                    bombCount++;
                }
            }

            if ((currCol - 1) >= 0)
            {
                if (gameField[currRow, currCol - 1] == '*')
                {
                    bombCount++;
                }
            }

            if ((currCol + 1) < gameField.GetLength(1))
            {
                if (gameField[currRow, currCol + 1] == '*')
                {
                    bombCount++;
                }
            }

            if ((currRow - 1 >= 0) && ((currCol - 1) >= 0))
            {
                if (gameField[currRow - 1, currCol - 1] == '*')
                {
                    bombCount++;
                }
            }

            if (((currRow - 1) >= 0) && ((currCol + 1) < gameField.GetLength(1)))
            {
                if (gameField[currRow - 1, currCol + 1] == '*')
                {
                    bombCount++;
                }
            }

            if (((currRow + 1) < gameField.GetLength(0)) && ((currCol - 1) >= 0))
            {
                if (gameField[currRow + 1, currCol - 1] == '*')
                {
                    bombCount++;
                }
            }

            if (((currRow + 1) < gameField.GetLength(0)) && ((currCol + 1) < gameField.GetLength(1)))
            {
                if (gameField[currRow + 1, currCol + 1] == '*')
                {
                    bombCount++;
                }
            }

            return char.Parse(bombCount.ToString());
        }
    }
}