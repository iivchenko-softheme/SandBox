using System;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace CSharp
{
    [TestFixture]
    public class RegexTests
    {
        [Test]
        public void Test()
        {
            var input = @"====================
Snap date: 8/17/2015 4:55:01 PM
eseutil.exe exit code: 0
D:\Program Files\Microsoft\Exchange Server\V14\Mailbox\Public Folder Database 1775008422\Public Folder Database 1775008422.edb

Extensible Storage Engine Utilities for Microsoft(R) Exchange Server
Version 14.03
Copyright (C) Microsoft Corporation. All Rights Reserved.

Initiating CHECKSUM mode...
        Database: C:\Windows\TEMP\4a2d69a5-c6a1-42a3-8a89-a0022653ce9a\Program Files\Microsoft\Exchange Server\V14\Mailbox\Public Folder Database 1775008422\Public Folder Database 1775008422.edb
  Temp. Database: TEMPCHKSUM35388.EDB


File: C:\Windows\TEMP\4a2d69a5-c6a1-42a3-8a89-a0022653ce9a\Program Fil



                     Checksum Status (% complete)



          0    10   20   30   40   50   60   70   80   90  100

          |----|----|----|----|----|----|----|----|----|----|

          ...................................................





4354 pages seen

0 bad checksums

0 correctable checksums

4000 uninitialized pages

0 wrong page numbers

0xcbae highest dbtime (pgno 0x148)



2177 reads performed

136 MB read

2 seconds taken

68 MB/second

1447387 milliseconds used

664 milliseconds per read

827 milliseconds for the slowest read

343 milliseconds for the fastest read





Operation completed successfully in 4.774 seconds.


====================
";
            var pattern = @"0[ ]+10[ ]+20[ ]+30[ ]+40[ ]+50[ ]+60[ ]+70[ ]+80[ ]+90[ ]+100\s+\|----\|----\|----\|----\|----\|----\|----\|----\|----\|----\|\s+(?<progress>\.*)";
            Console.WriteLine(Regex.IsMatch(input, pattern));

            Console.WriteLine(Regex.Match(input, pattern).Groups["progress"].Value.Length);
        }
    }
}
