namespace CSharp.Game
{
    public class Game : IOwner<IGameComponent> , IGameComponent
    {
        public Game()
        {
            State = new MenuScreen(this);
        }

        public IGameComponent State { get; set; }

        public void Update()
        {
            State.Update();
        }

        public void Draw()
        {
            State.Draw();
        }
    }
}
