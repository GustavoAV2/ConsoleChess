
namespace tabuleiro
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

        public void insertPiece(Piece piece, Position pos)
        {
            pieces[pos.Line, pos.Column] = piece;
            piece.position = pos;
        }
    }
}
