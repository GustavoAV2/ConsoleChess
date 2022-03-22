using tabuleiro;
using System;

namespace ConsoleChess
{
    class Tela
    {
        public static void viewTab(Tabuleiro tab)
        {
            for (int i = 0; i < tab.line; i++)
            {
                for (int j = 0; j < tab.columns; j++)
                {
                    if (tab.piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.piece(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
