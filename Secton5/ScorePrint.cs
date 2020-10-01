using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secton5
{
    class ScorePrint
    {
        public static void lastScore()
        {
            string path = "C:\\Users\\Public\\Documents\\myData.txt";
            var lastLine = File.ReadLines(path).Last();
            Console.WriteLine($"The last score you got was {lastLine}");
            Console.ReadLine();
        }
    }
}
