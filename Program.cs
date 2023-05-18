using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace CreateDate
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@".\");
            List<DateTime> CreatedDates = new List<DateTime>();
            string dik = "";
            foreach (string s in files)
            {
                dik += s + File.GetCreationTime($@".\{s}");
            }
            File.WriteAllText(@".\text.txt", dik);
        }
    }
}
