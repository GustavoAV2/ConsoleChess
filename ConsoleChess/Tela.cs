using entities;
using domain;
using System;

namespace ConsoleChess
{
    class Tela
    {
        public static void viewTab(Tabuleiro tab)
        {
            for (int i = 0; i < tab.line; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.columns; j++)
                {
                    viewPiece(tab.piece(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }
        public static void viewTab(Tabuleiro tab, bool[,] possibleMoves)
        {
            ConsoleColor originalColor = Console.BackgroundColor;
            ConsoleColor possibleMoveColor = ConsoleColor.DarkGray;
            for (int i = 0; i < tab.line; i++)
            {
                Console.Write(8 - i +  " "); 
                for (int j = 0; j < tab.columns; j++)
                {
                    if (possibleMoves[i, j])
                    {
                        Console.BackgroundColor = possibleMoveColor;
                    }
                    else
                    {
                        Console.BackgroundColor = originalColor;
                    }
                    viewPiece(tab.piece(i, j));
                    Console.BackgroundColor = originalColor;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static void viewPiece(Piece piece)
        {
            if (piece == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (piece.color == Color.White)
                {
                    Console.Write(piece);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(piece);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }

        public static PosicaoXadrez readChessPosition()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int line = int.Parse(s[1] + "");
            return new PosicaoXadrez(column, line);
        }
    }
}
