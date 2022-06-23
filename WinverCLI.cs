using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winvercli
{
    class WinverCLI
    {
        static void Main(string[] args)
        {
            // From https://github.com/jdu2600/Windows10EtwEvents/blob/master/_src/Program.cs
            var product = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", "").ToString();
            var release = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ReleaseId", "").ToString();
            var build = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "BuildLabEx", "").ToString();
            var fullWinver = $"{product} {release} ({build})";
            Console.WriteLine(fullWinver);
            if (args.Length > 0)
            {
                using (var windowsVersionFile = new StreamWriter(args[0]))
                {
                    windowsVersionFile.WriteLine(fullWinver);
                }
            }
        }
    }
}
