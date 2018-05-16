using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueManager.Core
{
    class Manage
    {
        public Manage() { }
        public void Processing()
        {

        }
        public void READFILE(string path)
        {
            if (!File.Exists(path))
            {
                   
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
