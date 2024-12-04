using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class OptionX
    {
        public void ExecuteOptionX(List<Team> arrings)
        {
            string file1 = "statistic.txt";//寻找路径
            StreamWriter sw = new StreamWriter(file1);
            sw.WriteLine("Football World Cup Winner:{0}", arrings[0].countryName);//写入世界杯冠军
            string winname = "";//写入射球数最多的球员
            int max = 0;
            for (int i = 0; i < arrings.Count; i++)
            {
                if (arrings[i].player1.sumGoal > max)
                    max = arrings[i].player1.sumGoal;
                if (arrings[i].player2.sumGoal > max)
                    max = arrings[i].player2.sumGoal;
            }
            for (int j = 0; j < arrings.Count; j++)
            {
                if (arrings[j].player1.sumGoal == max)
                {
                    winname = arrings[j].player1.name; //把射球数最高的成员名字赋值
                    sw.WriteLine("Golden Boot Award: {0}", winname);
                }
                if (arrings[j].player2.sumGoal == max)
                {
                    winname = arrings[j].player2.name;
                    sw.WriteLine("Golden Boot Award: {0}", winname);
                }
            }
            for (int j = 0; j < arrings.Count; j++)
            {
                if (arrings[j].fairPlayScore == max)
                {
                    sw.WriteLine("Fair Play Award:{0}", arrings[j].countryName);//写入公平竞赛奖
                }
            }
        }
    }
}
