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
            //输出最高射球数球员
            arrings.Sort((team1, team2) =>
            {
                int result = team1.player1.sumGoal.CompareTo(team1.player1.sumGoal.CompareTo(team2.player1.sumGoal.CompareTo(team2.player2.sumGoal)));
                if (result == 0)
                {
                    result = team1.sumFinishGoalCount.CompareTo(team2.sumFinishGoalCount);
                }
                return result;
            });
            if (arrings[0].player1.sumGoal > arrings[0].player2.sumGoal)
                Console.WriteLine("Golden Boot Award: {0}", arrings[0].player1.name);
            if (arrings[0].player1.sumGoal < arrings[0].player2.sumGoal)
            {
                Console.WriteLine("Golden Boot Award: {0}", arrings[0].player2.name);
            }
            if(arrings[0].player1.sumGoal == arrings[0].player2.sumGoal)
                {
                    Random random = new Random();
                    if(random.Next(0,100)<50)
                    {
                        Console.WriteLine("Golden Boot Award: {0}", arrings[0].player1.name);
                    }
                    else
                    {
                        Console.WriteLine("Golden Boot Award: {0}", arrings[0].player2.name);
                    }
                }
            //恢复按球队积分总数排序
            arrings.Sort((team1, team2) =>
            {
                int result = team2.sumCount.CompareTo(team1.sumCount);
                if (result == 0)
                {
                    result = team2.sumFinishGoalCount.CompareTo(team1.sumFinishGoalCount);
                    if (result == 0)
                    {
                        Random random = new Random();
                        result = random.Next(1, 100) < 50 ? -1 : 1;
                    }
                }
                return result;
            });
        }
        public void ExecuteOptionE1(List<Team> arrings)
        {
            //计算最少Fairplayscore球队
            arrings.Sort((team1, team2) =>
            {
                int result = team1.fairPlayScore.CompareTo(team2.fairPlayScore);
                if(result == 0)
                {
                    result = team1.sumFinishGoalCount.CompareTo(team2.sumFinishGoalCount);
                    Console.WriteLine("Fair Play Award:{0}", arrings[0].countryName);
                }
                else
                {
                    Console.WriteLine("Fair Play Award:{0}", arrings[0].countryName);
                }
                return result;
            });
            //恢复按球队积分总数排序
            arrings.Sort((team1, team2) =>
            {
                int result = team2.sumCount.CompareTo(team1.sumCount);
                if (result == 0)
                {
                    result = team2.sumFinishGoalCount.CompareTo(team1.sumFinishGoalCount);
                    if (result == 0)
                    {
                        Random random = new Random();
                        result = random.Next(1, 100) < 50 ? -1 : 1;
                    }
                }
                return result;
            });
        }
    }
}
