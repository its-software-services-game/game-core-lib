namespace Its.Games.Core.Commons
{
    public interface IPlayer
    {
        int PlayerId { get; set; }

        //For example "๋John" or "Smith"
        string PlayerName { get; set; }

        IMove GetMove(IBoard board);
    }
}