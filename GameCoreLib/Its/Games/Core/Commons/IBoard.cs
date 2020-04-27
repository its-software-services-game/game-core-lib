namespace Its.Games.Core.Commons
{
    public interface IBoard
    {
        void Init();        
        void Put(ICoordinate coordinate, IMarker mark);
        IMarker Get(ICoordinate coordinate);
    }
}