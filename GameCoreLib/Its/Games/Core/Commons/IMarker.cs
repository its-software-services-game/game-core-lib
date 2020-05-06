namespace Its.Games.Core.Commons
{
    public interface IMarker
    {
        IMarker GetOpponentMarker();

        int Id { get; set; }

        //For example "Black" or "White"
        string Name { get; set; }
    }
}