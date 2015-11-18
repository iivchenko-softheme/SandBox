using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CSharp
{
    [TestFixture]
    public sealed class TypeTests
    {
        [Test]
        public void ToArrayTest()
        {
            var list = new List<int> { 1, 2 };

            foreach (var element in list.Select(x => x.GetType()).ToArray())
            {
                Console.WriteLine(element);
            }
        }
    }
}
