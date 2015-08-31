using System;

namespace CSharp.Game
{
    public class MenuScreen : IGameComponent
    {
        private readonly IOwner<IGameComponent> _owner;

        public MenuScreen(IOwner<IGameComponent> owner)
        {
            _owner = owner;
        }

        public void Update()
        {
            if (true)
            {
                Console.WriteLine(GetType().Name + " Update");
                _owner.State = new GamePlay(_owner);
            }
        }

        public void Draw()
        {
            Console.WriteLine(GetType().Name + " Draw");
        }
    }
}
