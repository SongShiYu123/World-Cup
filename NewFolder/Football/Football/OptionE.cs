using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class OptionE
    {
        public void ExecuteOptionE(List<Team> arrings)
        {
            string winname = "";
            int max = 0;
            //将最高goal赋值给max
            for (int i = 0; i < arrings.Count; i++)
            {
                if (arrings[i].player1.goal > max)
                    max = arrings[i].player1.goal;
                if (arrings[i].player2.goal > max)
                    max = arrings[i].player2.goal;
            }
            for (int j = 0; j < arrings.Count; j++)
            {
                if (arrings[j].player1.goal == max)
                {
                    winname = arrings[j].player1.name; //把射球数最高的成员名字赋值
                    Console.WriteLine("Golden Boot Award: {0}", winname);
                }
                if (arrings[j].player2.goal == max)
                {
                    winname = arrings[j].player2.name;
                    Console.WriteLine("Golden Boot Award: {0}", winname);
                }
            }
        }
        public void ExecuteOptionE1(List<Team> arrings)
        {
            int max1 = arrings[0].fairPlayScore;
            for (int i = 0; i < arrings.Count; i++)
            {
                if (arrings[i].fairPlayScore < max1)
                {
                    max1 = arrings[i].fairPlayScore;
                }
            }
            for (int j = 0; j < arrings.Count; j++)
            {
                if (arrings[j].fairPlayScore == max1)
                {
                    Console.WriteLine("Fair Play Award:{0}", arrings[j].countryName);
                }
            }
        }
    }
}
