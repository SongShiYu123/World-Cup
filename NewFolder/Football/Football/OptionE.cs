using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class OptionE
    {
        //0 1 2 3 4 5 6 7
        //0 1 2 3 
        public void ExecuteOptionE(List<Team> arrings)
        {
            //输出最高射球数球员           
            int max1 = 0;//最高射球数
            for (int i = 0; i < arrings.Count; i++)
            {
                if (arrings[i].player1.sumGoal > max1)
                {
                    max1 = arrings[i].player1.sumGoal;
                }
                if (arrings[i].player2.sumGoal > max1)
                {
                    max1 = arrings[i].player2.sumGoal;
                }
            }
            Player maxplayer = new Player();//找出最高射球数相等的球员并同时只保留sumFinishGoalCount最大的
            int max = 0;
            for (int i = 0; i < arrings.Count; i++)
            {
                if (arrings[i].player1.sumGoal == max1 && arrings[i].sumFinishGoalCount > max)
                {
                    maxplayer = arrings[i].player1;
                    max = arrings[i].sumFinishGoalCount;
                }
                if (arrings[i].player2.sumGoal == max1 && arrings[i].sumFinishGoalCount > max)
                {
                    maxplayer = arrings[i].player2;
                    max = arrings[i].sumFinishGoalCount;
                }
            }
            for (int i = 0; i < arrings.Count; i++)
            {
                if (arrings[i].player1.sumGoal == max1 && arrings[i].sumFinishGoalCount == max && arrings[i].player2.sumGoal == max1)
                {
                    Random random = new Random();
                    if (random.Next(0, 100) < 50)
                        Console.WriteLine("Golden Boot Award: {0}", arrings[i].player1.name);
                    else
                        Console.WriteLine("Golden Boot Award: {0}", arrings[i].player2.name);
                    break;
                }
                else if (arrings[i].player1.sumGoal == max1 && arrings[i].sumFinishGoalCount == max)
                {
                    Console.WriteLine("Golden Boot Award: {0}", arrings[i].player1.name);
                }
                else if (arrings[i].player2.sumGoal == max1 && arrings[i].sumFinishGoalCount == max)
                {
                    Console.WriteLine("Golden Boot Award: {0}", arrings[i].player2.name);
                }
            }
        }
        public void ExecuteOptionE1(List<Team> arrings)
        {
            //计算最少Fairplayscore球队
            int min = arrings[0].fairPlayScore;//最小fairplay
            for(int i = 0;i< arrings.Count;i++)
            {
                if (arrings[i].fairPlayScore<min)
                {
                    min = arrings[i].fairPlayScore;
                }
            }
            int max = 0;//球队积分大的
            for (int i = 0; i < arrings.Count; i++)
            {
                if (arrings[i].fairPlayScore == min && arrings[i].sumFinishGoalCount>max)
                {
                    max = arrings[i].sumFinishGoalCount; 
                }
            }
            List<Team> arring = new List<Team>();
            for (int i = 0; i < arrings.Count; i++)//判断会不会有多个符合条件的
            {
                if (arrings[i].fairPlayScore == min && arrings[i].sumFinishGoalCount == max)
                {
                    arring.Add(arrings[i]);
                }
            }
            Random random = new Random();
            Console.WriteLine("Fair Play Award:{0}", arring[random.Next(0,arring.Count)].countryName);           
        }
    }
}
