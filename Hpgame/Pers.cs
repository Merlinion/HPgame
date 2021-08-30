using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hpgame
{
    class Pers
    {
        public int prerecord;
        public int Import()
        {
            if (File.Exists("data.txt") == true)
            {
                StreamReader file = new StreamReader("data.txt");
                prerecord = Convert.ToInt32(file.ReadLine());
                file.Close();
                return prerecord;
            }
            else
            {
                File.Create("data.txt");
                return 0;
            }

        }
        public bool Export(int score)
        {        
                StreamWriter file = new StreamWriter("data.txt");
                file.WriteLine(score);
                file.Close();
                return true;         
            
        }
    }
}
