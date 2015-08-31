using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace CSharp
{
    [TestFixture]
    public class ProcessTests
    {
        [Test]
        public void Test_ReadToEnd()
        {
            var info = new ProcessStartInfo(@"e:\My\SandBox\ConsoleApp\bin\Debug\ConsoleApp.exe")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false
            };

            var eseutil = Process.Start(info);

            while (!eseutil.HasExited)
            {
                var eseOutput = eseutil.StandardOutput.ReadToEnd();

                Console.WriteLine(eseOutput);
            }
        }

        [Test]
        public void Test_BegingRead()
        {
            var info = new ProcessStartInfo(@"e:\My\SandBox\ConsoleApp\bin\Debug\ConsoleApp.exe")
            {
                //RedirectStandardOutput = true,
                UseShellExecute = false,
            };

            var eseutil = new Process();
            eseutil.StartInfo = info;
            eseutil.OutputDataReceived += (sender, args) =>
            {
                Console.WriteLine(args.Data);
            };
            
            eseutil.Start();

            eseutil.BeginOutputReadLine();

            eseutil.WaitForExit();
            
        }

        [Test]
        public void Test_Read()
        {
            var info = new ProcessStartInfo(@"e:\My\SandBox\ConsoleApp\bin\Debug\ConsoleApp.exe")
            {
                //RedirectStandardOutput = true,
                UseShellExecute = false
            };

            var eseutil = new Process
            {
                StartInfo = info
            };

            eseutil.Start();
            eseutil.WaitForExit();
            eseutil.StartInfo.RedirectStandardOutput = true;

            Console.WriteLine(eseutil.StandardOutput.ReadToEnd());
        }
    }
}
