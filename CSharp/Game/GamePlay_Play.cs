using System;

namespace CSharp.Game
{
    public class GamePlay_Play : IGameComponent
    {
        private ISubOwner<IGameComponent, IGameComponent> _owner;

        public GamePlay_Play(ISubOwner<IGameComponent, IGameComponent> owner)
        {
            _owner = owner;
        }

        public void Update()
        {
            Console.WriteLine(GetType().Name + " Update");

            _owner.Owner
        }

        public void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}
