using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class OptionA
    {
        public void ExecuteOptionA(List<Team> arrings, Game[] match)
        {
            for (int i = 0; i < arrings.Count; i++)
            {
                for (int j = i + 1; j < arrings.Count; j++)
                {
                    match[i] = new Game(arrings[i], arrings[j]);
                    match[i].playGame();
                    match[i].winmatch();
                    match[i].playGameResult();
                    arrings[i].Cardcount();//纪录每次比赛的红牌黄牌数
                    arrings[j].Cardcount();
                }
            }
        }
        public void ExecuteOptionA1(List<Team> arrings)
        {
            //排序
            arrings.Sort((team1, team2) =>
            {
                int result = team2.sumCount.CompareTo(team1.sumCount);
                if (result == 0)
                {
                    result = team2.finishGoalCount.CompareTo(team1.finishGoalCount);
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
