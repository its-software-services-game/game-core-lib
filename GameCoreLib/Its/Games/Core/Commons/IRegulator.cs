namespace Its.Games.Core.Commons
{
    public interface IRegulator
    {
        void Init(IBoard board);
        bool IsValidMove(IBoard board, IMove move);
        bool IsPlayable(IBoard board, IPlayer player);
        bool IsOver(IBoard board);
        IPlayer Winner { get; set; }
        IBoard Move(IBoard board, IMove move);
    }
}