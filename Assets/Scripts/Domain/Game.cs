namespace UCR.WorkshopTDD.Domain
{
    public class Game
    {
        public const int Rows = 3;
        public const int Columns = 3;
        public Board Board { get; private set; }
        public void Start()
        {
            Board = new Board(Rows, Columns);
        }
    }
}
