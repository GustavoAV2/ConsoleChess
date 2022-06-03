using entities;


namespace domain
{
    class Torre : Piece
    {
        public Torre(Tabuleiro tab, Color color) : base(tab, color)
        { }

        public override string ToString()
        {
            return "T";
        }
        private bool canMove(Position pos)
        {
            Piece p = tab.piece(pos);
            return p == null || p.color != this.color;
        }

        public override bool[,] possibleMoves()
        {
            bool[,] mat = new bool[tab.line, tab.columns];
            Position pos = new Position(0, 0);

            //Verificando acima
            pos.setValue(pos.Line - 1, pos.Column);
            while (tab.validatePosition(pos) && canMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
                if (tab.piece(pos) != null && tab.piece(pos).color != color)
                {
                    break;
                }
                pos.Line = pos.Line - 1;
            }

            //Verificando Abaixo
            pos.setValue(pos.Line + 1, pos.Column);
            while (tab.validatePosition(pos) && canMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
                if (tab.piece(pos) != null && tab.piece(pos).color != color)
                {
                    break;
                }
                pos.Line = pos.Line + 1;
            }

            //Verificando Direita
            pos.setValue(pos.Line, pos.Column + 1);
            while (tab.validatePosition(pos) && canMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
                if (tab.piece(pos) != null && tab.piece(pos).color != color)
                {
                    break;
                }
                pos.Column = pos.Column + 1;
            }

            //Verificando Esquerda
            pos.setValue(pos.Line, pos.Column - 1);
            while (tab.validatePosition(pos) && canMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
                if (tab.piece(pos) != null && tab.piece(pos).color != color)
                {
                    break;
                }
                pos.Column = pos.Column - 1;
            }
            return mat;
        }
    }
}
