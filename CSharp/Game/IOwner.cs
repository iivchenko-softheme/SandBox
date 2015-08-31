namespace CSharp.Game
{
    public interface IOwner<TState>  where TState : IGameComponent
    {
        TState State { get; set; }
    }
}
