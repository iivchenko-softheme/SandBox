using System;
using NUnit.Framework;

namespace CSharp
{
    [TestFixture]
    public class Time
    {
        [Test]
        public void TotalMinutes()
        {
            // var date = DateTime.Now;
            var date1 = new DateTime(2000, 1, 1, 0, 0, 0);
            var date2 = new DateTime(2000, 1, 1, 0, 0, 35);
            var totalMinutes1 = (uint)date1.TimeOfDay.TotalMinutes;
            var totalMinutes2 = (uint)date2.TimeOfDay.TotalMinutes;

            Console.WriteLine(date1);
            Console.WriteLine(totalMinutes1);

            Console.WriteLine(date2);
            Console.WriteLine(totalMinutes2);
        }
    }
}
