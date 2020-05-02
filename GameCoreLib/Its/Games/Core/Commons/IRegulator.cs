namespace Its.Games.Core.Commons
{
    public interface IRegulator
    {
        void Init();
        bool IsValidMove(IMove move);
        bool IsPlayable(IPlayer player);
        bool IsOver();
        void Move(IMove move);
    }
}