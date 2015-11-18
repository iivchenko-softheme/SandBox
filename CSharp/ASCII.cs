using System;
using System.Runtime.ConstrainedExecution;
using NUnit.Framework;

namespace CSharp
{
    [TestFixture]
    public class ASCII
    {
        [Test]
        public void SymToCode()
        {
            var syms = new[] { 'シ', 'À', '!', '·' };

            foreach (var sym in syms)
            {
                Console.WriteLine(sym + " " + (int)sym);
            }
        }
    }
}
