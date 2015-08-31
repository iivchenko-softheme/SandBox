using System;
using NUnit.Framework;

namespace CSharp
{
    [TestFixture]
    public class Environment
    {
        [Test]
        public void Test()
        {
            Console.WriteLine(System.Environment.GetEnvironmentVariable("ExchangeInstallPath"));
        }


    }
}
