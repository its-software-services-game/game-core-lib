namespace Its.Games.Core.Commons
{
    public interface IBoard
    {
        void Init();
        void Move(IMove move);
    }
}