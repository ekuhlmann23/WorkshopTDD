namespace UCR.WorkshopTDD.Domain
{
    public class Board
    {
        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            IsEmpty = true;
        }
        public int Rows { get; }
        public int Columns { get; }
        public bool IsEmpty { get; }

        public Symbol GetSymbol(int row, int column)
        {
            return Symbol.Empty;
        }
    }
}
