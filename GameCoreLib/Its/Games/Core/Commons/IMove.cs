namespace Its.Games.Core.Commons
{
    public interface IMove
    {
        IMarker Mark { get; set; }
        ICoordinate Coordinate { get; set; }
    }
}