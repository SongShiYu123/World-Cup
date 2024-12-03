﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class OptionX
    {
        public void ExecuteOptionX(Team[] arring)
        {
            string file1 = "statistic.txt";//寻找路径
            StreamWriter sw = new StreamWriter(file1);
            sw.WriteLine("Football World Cup Winner:{0}", arring[0].countryName);//写入世界杯冠军
            string winname = "";//写入射球数最多的球员
            int max = 0;
            for (int i = 0; i < arring.Length; i++)
            {
                if (arring[i].player1.goal > max)
                    max = arring[i].player1.goal;
                if (arring[i].player2.goal > max)
                    max = arring[i].player2.goal;
            }
            for (int j = 0; j < arring.Length; j++)
            {
                if (arring[j].player1.goal == max)
                {
                    winname = arring[j].player1.name; //把射球数最高的成员名字赋值
                    sw.WriteLine("Golden Boot Award: {0}", winname);
                }
                if (arring[j].player2.goal == max)
                {
                    winname = arring[j].player2.name;
                    sw.WriteLine("Golden Boot Award: {0}", winname);
                }
            }
            for (int j = 0; j < arring.Length; j++)
            {
                if (arring[j].fairPlayScore == max)
                {
                    sw.WriteLine("Fair Play Award:{0}", arring[j].countryName);//写入公平竞赛奖
                }
            }
        }
    }
}
