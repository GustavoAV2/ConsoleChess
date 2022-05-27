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
                Console.Write(8 - i +  " "); 
                for (int j = 0; j < tab.columns; j++)
                {
                    if (tab.piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        viewPiece(tab.piece(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static void viewPiece(Piece piece)
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
