using System;
using NUnit.Framework;

namespace CSharp.Patterns.StatePattern
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test()
        {
            var product = new Product();

            Console.WriteLine(product.Hello());
            Console.WriteLine(product.Hello());
            Console.WriteLine(product.Hello());
            Console.WriteLine(product.Hello());
        }
    }
}
