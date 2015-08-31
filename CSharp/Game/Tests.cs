using System.Threading;
using NUnit.Framework;

namespace CSharp.Game
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test()
        {
            var game = new Game();

            while (true)
            {
                game.Update();
                game.Draw();
                Thread.Sleep(1000);
            }
        }
    }
}
