using System;
using tabuleiro;

namespace chess
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turn;
        private Color actualPlayer;
        public bool finished { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new(8, 8);
            turn = 1;
            actualPlayer = Color.White;
            finished = false;
            createAllPieces();
        }

        public void executeMoviment(Position origin, Position destination)
        {
            Piece p = tab.removePiece(origin);
            p.addQtdMove();
            Piece pieceKilled = tab.removePiece(destination);
            tab.insertPiece(p, destination);
        }

        private void createAllPieces()
        {
            tab.insertPiece(new Torre(tab, Color.Black), new PosicaoXadrez('c', 1).toPosition());
            tab.insertPiece(new Torre(tab, Color.Black), new PosicaoXadrez('c', 2).toPosition());
            tab.insertPiece(new Torre(tab, Color.Black), new PosicaoXadrez('d', 2).toPosition());
            tab.insertPiece(new Torre(tab, Color.Black), new PosicaoXadrez('e', 2).toPosition());
            tab.insertPiece(new Torre(tab, Color.Black), new PosicaoXadrez('e', 1).toPosition());
            tab.insertPiece(new Rei(tab, Color.Black), new PosicaoXadrez('d', 1).toPosition());
            tab.insertPiece(new Torre(tab, Color.Black), new PosicaoXadrez('h', 1).toPosition());
            tab.insertPiece(new Torre(tab, Color.Black), new PosicaoXadrez('a', 1).toPosition());

            tab.insertPiece(new Torre(tab, Color.White), new PosicaoXadrez('c', 7).toPosition());
            tab.insertPiece(new Torre(tab, Color.White), new PosicaoXadrez('c', 8).toPosition());
            tab.insertPiece(new Torre(tab, Color.White), new PosicaoXadrez('d', 7).toPosition());
            tab.insertPiece(new Torre(tab, Color.White), new PosicaoXadrez('e', 7).toPosition());
            tab.insertPiece(new Torre(tab, Color.White), new PosicaoXadrez('e', 8).toPosition());
            tab.insertPiece(new Rei(tab, Color.White), new PosicaoXadrez('d', 8).toPosition());
            tab.insertPiece(new Torre(tab, Color.White), new PosicaoXadrez('h', 8).toPosition());
            tab.insertPiece(new Torre(tab, Color.White), new PosicaoXadrez('a', 8).toPosition());
        }
    }
}
