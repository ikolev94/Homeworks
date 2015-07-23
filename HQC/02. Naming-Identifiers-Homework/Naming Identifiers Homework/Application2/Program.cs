namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class Minesweeper
    {
        public static void Main()
        {
            string command;
            char[,] board = BoardCreator();
            char[,] bombs = BombsCreator();
            int bombsCounter = 0;
            bool explode = false;
            List<Player> winners = new List<Player>(6);
            int row = 0;
            int col = 0;
            bool isStart = true;
            const int NumberOfAllBombs = 35;
            bool winTheGame = false;

            do
            {
                if (isStart)
                {
                    Console.WriteLine(
                        "Let's play “BOMBS”. Try to find filds whith bombs."
                        + "Command 'top' display position, 'restart' restart game, 'exit' for game over");
                    FieldPrinter(board);
                    isStart = false;
                }

                Console.Write("Choose rows and column : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out col)
                        && row < board.GetLength(0) && col < board.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PositionDisplay(winners);
                        break;
                    case "restart":
                        board = BoardCreator();
                        bombs = BombsCreator();
                        FieldPrinter(board);
                        break;
                    case "exit":
                        Console.WriteLine("Bye - Bye!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                PrintNumberOfNeighbourBombs(board, bombs, row, col);
                                bombsCounter++;
                            }

                            if (NumberOfAllBombs == bombsCounter)
                            {
                                winTheGame = true;
                            }
                            else
                            {
                                FieldPrinter(board);
                            }
                        }
                        else
                        {
                            explode = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nWrong command\n");
                        break;
                }

                if (explode)
                {
                    AllNumberOfNeighbourBombsHandler(bombs);
                    FieldPrinter(bombs);
                    Console.Write("\nGame Over You have {0} points. " + "Write your name: ", bombsCounter);
                    string nickName = Console.ReadLine();
                    Player player = new Player(nickName, bombsCounter);
                    if (winners.Count < 5)
                    {
                        winners.Add(player);
                    }
                    else
                    {
                        for (int i = 0; i < winners.Count; i++)
                        {
                            if (winners[i].Points < player.Points)
                            {
                                winners.Insert(i, player);
                                winners.RemoveAt(winners.Count - 1);
                                break;
                            }
                        }
                    }

                    winners.Sort(
                        (player1, player2) => string.Compare(player2.Name, player1.Name, StringComparison.Ordinal));
                    winners.Sort((player1, player2) => player2.Points.CompareTo(player1.Points));
                    PositionDisplay(winners);

                    board = BoardCreator();
                    bombs = BombsCreator();
                    bombsCounter = 0;
                    explode = false;
                    isStart = true;
                }

                if (winTheGame)
                {
                    Console.WriteLine("\nBRAVOOO!");
                    FieldPrinter(bombs);
                    Console.WriteLine("Write your nickname: ");
                    string winnerNickName = Console.ReadLine();
                    Player winner = new Player(winnerNickName, bombsCounter);
                    winners.Add(winner);
                    PositionDisplay(winners);
                    board = BoardCreator();
                    bombs = BombsCreator();
                    bombsCounter = 0;
                    winTheGame = false;
                    isStart = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria!");
            Console.Read();
        }

        private static void PositionDisplay(List<Player> players)
        {
            Console.WriteLine("\nPoints:");
            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, players[i].Name, players[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No one wins yet!\n");
            }
        }

        private static void PrintNumberOfNeighbourBombs(char[,] board, char[,] bombs, int row, int col)
        {
            char numberOfNeighbourBombs = NumberOfNeighbourBombsClaculator(bombs, row, col);
            bombs[row, col] = numberOfNeighbourBombs;
            board[row, col] = numberOfNeighbourBombs;
        }

        private static void FieldPrinter(char[,] board)
        {
            int rowMaxSize = board.GetLength(0);
            int colMaxSize = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rowMaxSize; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < colMaxSize; j++)
                {
                    Console.Write("{0} ", board[i, j]);
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] BoardCreator()
        {
            int boardRows = 5;
            int boardColumns = 10;
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

        private static char[,] BombsCreator()
        {
            int rowMaxSize = 5;
            int colMaxSize = 10;
            char[,] board = new char[rowMaxSize, colMaxSize];

            for (int i = 0; i < rowMaxSize; i++)
            {
                for (int j = 0; j < colMaxSize; j++)
                {
                    board[i, j] = '-';
                }
            }

            List<int> randomNumbersColection = new List<int>();
            while (randomNumbersColection.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!randomNumbersColection.Contains(randomNumber))
                {
                    randomNumbersColection.Add(randomNumber);
                }
            }

            foreach (int rand in randomNumbersColection)
            {
                int col = rand / colMaxSize;
                int row = rand % colMaxSize;
                if (row == 0 && rand != 0)
                {
                    col--;
                    row = colMaxSize;
                }
                else
                {
                    row++;
                }

                board[col, row - 1] = '*';
            }

            return board;
        }

         private static void AllNumberOfNeighbourBombsHandler(char[,] board) 
        {
            int rowMaxSize = board.GetLength(0);
            int colMaxSize = board.GetLength(1);

            for (int i = 0; i < rowMaxSize; i++)
            {
                for (int j = 0; j < colMaxSize; j++)
                {
                    if (board[i, j] != '*')
                    {
                        char numberOfNeighbourBombs = NumberOfNeighbourBombsClaculator(board, i, j);
                        board[i, j] = numberOfNeighbourBombs;
                    }
                }
            }
        }

        private static char NumberOfNeighbourBombsClaculator(char[,] board, int row, int col)
        {
            int neighbourBombsCount = 0;
            int rowMaxSize = board.GetLength(0);
            int colMaxSize = board.GetLength(1);

            if (row - 1 >= 0)
            {
                if (board[row - 1, col] == '*')
                {
                    neighbourBombsCount++;
                }
            }

            if (row + 1 < rowMaxSize)
            {
                if (board[row + 1, col] == '*')
                {
                    neighbourBombsCount++;
                }
            }

            if (col - 1 >= 0)
            {
                if (board[row, col - 1] == '*')
                {
                    neighbourBombsCount++;
                }
            }

            if (col + 1 < colMaxSize)
            {
                if (board[row, col + 1] == '*')
                {
                    neighbourBombsCount++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (board[row - 1, col - 1] == '*')
                {
                    neighbourBombsCount++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < colMaxSize))
            {
                if (board[row - 1, col + 1] == '*')
                {
                    neighbourBombsCount++;
                }
            }

            if ((row + 1 < rowMaxSize) && (col - 1 >= 0))
            {
                if (board[row + 1, col - 1] == '*')
                {
                    neighbourBombsCount++;
                }
            }

            if ((row + 1 < rowMaxSize) && (col + 1 < colMaxSize))
            {
                if (board[row + 1, col + 1] == '*')
                {
                    neighbourBombsCount++;
                }
            }

            return char.Parse(neighbourBombsCount.ToString());
        }
    }
}