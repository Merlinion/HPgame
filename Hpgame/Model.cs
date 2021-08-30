using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hpgame
{
    class Model
    {
        public List<bool> gnomehit = new List<bool>();
        public int hp = 100;
        public int attack1 = 0;
        public int attack2 = 0;
        public int hurtme = 0;
        public int irany = 1;
        public int score = 0;

        public List<bool> csekkbox = new List<bool>();
        public List<int> atk1 = new List<int>();
        public List<int> atk2 = new List<int>();
        public List<int[]> loirany = new List<int[]>();
        /*if (pictureBox1.Collides with x that has "doboz" tag)
         *  x.Image = FromFile("dobozhit.gif")
         *  x.Controls.Remove();
         */
        public int szamnov = 3;
        public int noveno = 0;
        public int szamgnom = 3;
        public int gnomno = 0;
        

    }
}
