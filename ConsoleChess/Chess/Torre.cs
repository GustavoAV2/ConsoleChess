using tabuleiro;


namespace chess
{
    class Torre : Piece
    {
        public Torre(Tabuleiro tab, Color color) : base(tab, color)
        { }

        public override string ToString()
        {
            return "T";
        }
    }
}
