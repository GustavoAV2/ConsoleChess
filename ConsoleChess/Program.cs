﻿using domain;
using System;
using entities;
using entities.exceptions;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez game = new PartidaDeXadrez();
                while (!game.finished)
                {
                    Console.Clear();

                    Tela.viewTab(game.tab);

                    Console.Write("Origem:");
                    Position origin = Tela.readChessPosition().toPosition();

                    bool[,] possiblePositions = game.tab.piece(origin).possibleMoves();

                    Console.Clear();
                    Tela.viewTab(game.tab, possiblePositions);

                    Console.Write("Destino:");
                    Position destination = Tela.readChessPosition().toPosition();

                    game.executeMoviment(origin, destination);
                }
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
