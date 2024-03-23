using System;
namespace Totito
{
    internal class Program
    {
        static char[,,] board = new char[3, 3, 3]; 

        static void Main(string[] args)
        {
            InitializeBoard(); 

            int currentPlayer = 1; 

            while (true)
            {
                PrintBoard(); 

                Console.Write($"Jugador {(currentPlayer == 1 ? "X" : "O")}, ingrese la fila (0-2): ");
                int row = int.Parse(Console.ReadLine());

                Console.Write($"Jugador {(currentPlayer == 1 ? "X" : "O")}, ingrese la columna (0-2): ");
                int col = int.Parse(Console.ReadLine());

                Console.Write($"Jugador {(currentPlayer == 1 ? "X" : "O")}, ingrese la profundidad (0-2): ");
                int depth = int.Parse(Console.ReadLine());

                if (MakeMove(row, col, depth, currentPlayer))
                {
                    if (CheckWin(currentPlayer))
                    {
                        PrintBoard();
                        Console.WriteLine($"¡El jugador {(currentPlayer == 1 ? "X" : "O")} ha ganado!");
                        break;
                    }
                    else if (CheckDraw())
                    {
                        PrintBoard();
                        Console.WriteLine("¡Es un empate!");
                        break;
                    }

                    currentPlayer = (currentPlayer == 1) ? 2 : 1; 
                }
                else
                {
                    Console.WriteLine("Movimiento inválido, intente de nuevo.");
                }
            }

            Console.ReadLine();
        }

        static void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        board[i, j, k] = ' '; 
                    }
                }
            }
        }

        static void PrintBoard()
        {
            Console.Clear();
            Console.WriteLine("Profundidad 0:");
            PrintLayer(0);
            Console.WriteLine("Profundidad 1:");
            PrintLayer(1);
            Console.WriteLine("Profundidad 2:");
            PrintLayer(2);
        }

        static void PrintLayer(int depth)
        {
            Console.WriteLine("  0 1 2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j, depth] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static bool MakeMove(int row, int col, int depth, int player)
        {
            if (row < 0 || row > 2 || col < 0 || col > 2 || depth < 0 || depth > 2 || board[row, col, depth] != ' ')
            {
                return false; 
            }

            board[row, col, depth] = (player == 1) ? 'X' : 'O'; 
            return true;
        }

        static bool CheckWin(int player)
        {
            char symbol = (player == 1) ? 'X' : 'O';

            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (board[i, 0, k] == symbol && board[i, 1, k] == symbol && board[i, 2, k] == symbol)
                        {
                            return true;
                        }
                    }
                }
            }

            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (board[0, j, k] == symbol && board[1, j, k] == symbol && board[2, j, k] == symbol)
                        {
                            return true;
                        }
                    }
                }
            }

            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (board[i, j, 0] == symbol && board[i, j, 1] == symbol && board[i, j, 2] == symbol)
                        {
                            return true;
                        }
                    }
                }
            }

            
            for (int k = 0; k < 3; k++)
            {
                if (board[0, 0, k] == symbol && board[1, 1, k] == symbol && board[2, 2, k] == symbol)
                {
                    return true;
                }

                if (board[0, 2, k] == symbol && board[1, 1, k] == symbol && board[2, 0, k] == symbol)
                {
                    return true;
                }
            }

            return false;
        }

        static bool CheckDraw()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (board[i, j, k] == ' ')
                        {
                            return false; 
                        }
                    }
                }
            }

            return true; 
        }
    }
}