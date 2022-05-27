using entities;


namespace domain
{
    class Rei : Piece
    {
        public Rei(Tabuleiro tab, Color color) : base(tab, color)
        { }

        public override string ToString()
        {
            return "R";
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
            if (tab.validatePosition(pos) && canMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            //Verificando NE
            pos.setValue(pos.Line - 1, pos.Column -1);
            if (tab.validatePosition(pos) && canMove(pos)){
                mat[pos.Line, pos.Column] = true;
            }

            //Verificando Direita
            pos.setValue(pos.Line, pos.Column + 1);
            if (tab.validatePosition(pos) && canMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            //Verificando SE
            pos.setValue(pos.Line + 1, pos.Column + 1);
            if (tab.validatePosition(pos) && canMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            //Verificando Abaixo
            pos.setValue(pos.Line + 1, pos.Column);
            if (tab.validatePosition(pos) && canMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            //Verificando SO
            pos.setValue(pos.Line + 1, pos.Column - 1);
            if (tab.validatePosition(pos) && canMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            //Verificando NO
            pos.setValue(pos.Line - 1, pos.Column - 1);
            if (tab.validatePosition(pos) && canMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            return mat;
        }
    }
}
