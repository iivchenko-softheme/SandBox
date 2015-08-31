namespace CSharp.Game
{
    public interface ISubOwner<TParent, TState> : IOwner<TState> where TState : IGameComponent
    {
        TParent Owner { get; }
    }
}
