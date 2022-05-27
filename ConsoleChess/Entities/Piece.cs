using System;
using tabuleiro;

namespace entities
{
    abstract class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public Tabuleiro tab { get; protected set; }
        public int qtMove { get; protected set; }

        public Piece(Tabuleiro tab, Color color)
        {
            this.tab = tab;
            this.qtMove = 0;
            this.color = color;
            this.position = null;
        }

        public void addQtdMove()
        {
            qtMove++;
        }

        public abstract bool[,] possibleMoves();
    }
}
