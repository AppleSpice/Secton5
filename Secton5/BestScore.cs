using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Secton5
{
    class BestScore
    {
        public static void PrintBest()
        {
            string path = "C:\\Users\\Public\\Documents\\myData.txt";
            String[] lines = File.ReadAllLines(path);
            long max = 0;
            long score = 0;
            foreach (String line in lines)
            {
                if (Int64.TryParse(line, out score))
                {
                    if (score > max)
                        max = score;
                }
            }
            Console.WriteLine("Maximum Score is " + max);
            Console.ReadLine();
        }
        
    }
}
