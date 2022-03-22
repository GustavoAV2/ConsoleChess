using chess;
using tabuleiro;
using System;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.insertPiece(new Rei(tab, Color.White), new Position(2, 4));
            tab.insertPiece(new Torre(tab, Color.White), new Position(1, 3));
            tab.insertPiece(new Torre(tab, Color.White), new Position(0, 0));

            Tela.viewTab(tab);

            Console.ReadLine();
        }
    }
}
