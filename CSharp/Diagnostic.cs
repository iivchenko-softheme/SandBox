using System.Diagnostics;
using System.IO;
using NUnit.Framework;

namespace CSharp
{
    [TestFixture]
    public class Diagnostic
    {

        public void Execute_Eseutil()
        {
            var info = new ProcessStartInfo(@"C:\Program Files\Microsoft\Exchange Server\V15\Bin\eseutil.exe", @"/k c:\Test2\Test.edb");
            
            var eseutil = Process.Start(info);

            eseutil.WaitForExit();

            using (var log = File.Open("c:\\log.txt", FileMode.Create))
            using (var writer = new StreamWriter(log))
            {
                writer.Write("Exit code: " + eseutil.ExitCode + "\r\n");
                writer.Write(eseutil.StandardOutput.ReadToEnd());
            }
        }
    }
}
