using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Player
    {
        public string name { get; set; }//球员名字
        public int goal { get; set; }//个人进球数
        public Player()
        {
            name = "";
            goal = 0;
        }
        public Player(string Name, int Goal)
        {
            name = Name;
            goal = Goal;
        }
    }
}
