using System;

namespace CSharp.Game
{
    public class GamePlay : IGameComponent
    {
        private readonly IOwner<IGameComponent> _owner;

        public GamePlay(IOwner<IGameComponent> owner)
        {
            _owner = owner;
        }

        public void Update()
        {
            Console.WriteLine(GetType().Name + " Update");
        }

        public void Draw()
        {
            Console.WriteLine(GetType().Name + " Draw");
        }
    }
}
