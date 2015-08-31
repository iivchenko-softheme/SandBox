using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using NUnit.Framework;

namespace CSharp
{
    [TestFixture]
    public class FileSystem
    {
        [Test]
        public void Drivers()
        {
            var letters = new List<string>();

            for (var letter = 'D'; letter <= 'Z'; letter++)
            {
                letters.Add(letter + ":\\");
                Console.Write(letter + " ");
            }

            Console.WriteLine();

            var drives = DriveInfo.GetDrives().Select(x => x.Name);

            foreach (var drive in drives)
            {
                Console.Write(drive + " ");
            }

            Console.WriteLine();

            foreach (var l in letters.Except(drives))
            {
                Console.Write(l + " ");
            }
        }

        [Test]
        public void Path()
        {
            //var path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), Guid.NewGuid().ToString() + "\\");
            var path =
                System.IO.Path.Combine(
                    System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData), "Some name");
            Console.WriteLine(path);

            Directory.CreateDirectory(path);

            using (var file = File.Open(System.IO.Path.Combine(path, DateTime.Now.ToString("yy-MM-dd HH-mm-ss") + ".txt"), FileMode.Create))
            {
                
            }
            
            
        }
    }
}
