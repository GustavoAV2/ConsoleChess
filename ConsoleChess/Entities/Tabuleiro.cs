
namespace entities
{
    class Tabuleiro
    {
        public int line { get; set; }
        public int columns { get; set; }
        private Piece[,] pieces;

        public Tabuleiro(int line, int columns)
        {
            this.line = line;
            this.columns = columns;
            pieces = new Piece[line, columns];
        }

        public Piece piece(int line, int columns)
        {
            return pieces[line, columns];
        }

        public Piece piece(Position pos)
        {
            return pieces[pos.Line, pos.Column];
        }

        public bool ifExistsPiece(Position pos)
        {
            VerifyPosition(pos);
            return piece(pos) != null;
        }

        public void insertPiece(Piece piece, Position pos)
        {
            if (ifExistsPiece(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pieces[pos.Line, pos.Column] = piece;
            piece.position = pos;
        }
        
        public Piece removePiece(Position pos)
        {
            if (piece(pos) == null)
            {
                return null;
            }
            Piece aux = piece(pos);
            aux.position = null;
            pieces[pos.Line, pos.Column] = null;
            return aux;
        }

        public void VerifyPosition(Position pos)
        {
            if (!validatePosition(pos))
            {
                throw new TabuleiroException("Posição invalida!");
            }
        }

        public bool validatePosition(Position pos)
        {
            if (pos.Line < 0 || pos.Line >= line || pos.Column < 0 || pos.Column >= columns)
            { return false; }
            return true;
        }

    }
}
