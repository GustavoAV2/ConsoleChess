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
                PartidaDeXadrez game = new PartidaDeXadrez();

                Tela.viewTab(game.tab);
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
