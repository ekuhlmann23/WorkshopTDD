namespace UCR.WorkshopTDD.Domain
{
    public class Board
    {
        private Symbol[,] board;

        public int Rows { get; }
        public int Columns { get; }
        public bool IsEmpty { get; }

        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            board = new Symbol[Rows, Columns];

            IsEmpty = true;
        }

        public Symbol GetSymbol(int row, int column)
        {
            return board[row - 1, column - 1];
        }

        public void SetSymbol(Symbol symbol, int row, int column)
        {
            board[row - 1, column - 1] = symbol;
        }
    }
}
