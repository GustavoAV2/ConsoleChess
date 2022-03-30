using chess;
using tabuleiro;
using System;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.insertPiece(new Torre(tab, Color.Black), new Position(0, 0));
                tab.insertPiece(new Torre(tab, Color.Black), new Position(1, 3));
                tab.insertPiece(new Rei(tab, Color.Black), new Position(0, 2));

                tab.insertPiece(new Torre(tab, Color.White), new Position(3, 5));
                //tab.insertPiece(new Torre(tab, Color.White), new Position(0, 0));
                //tab.insertPiece(new Rei(tab, Color.White), new Position(0, 0));

                Tela.viewTab(tab);
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
