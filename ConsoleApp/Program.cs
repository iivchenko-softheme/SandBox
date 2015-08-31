using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);

                //Console.WriteLine("String #{0}", i);

                Console.Write(".");
            }
        }
    }
}
