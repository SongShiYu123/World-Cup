using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class OptionA
    {
        public void ExecuteOptionA(ref int count, Team[] arring, Game[] match)
        {
            count++;
            //重置比赛信息A
            for(int x = 0;x< arring.Length;x++)
            {
                arring[x].red = 0;
                arring[x].yellow = 0;
                arring[x].presentCount = 0;
                arring[x].winCount = 0;
                arring[x].lossCount = 0;
                arring[x].drawCount = 0;
                arring[x].finishGoalCount = 0;
                arring[x].inputDoor = 0;
                arring[x].fairPlayScore = 0;
                arring[x].player1.goal = 0;
                arring[x].player2.goal = 0;
            }
            for (int i = 0; i < arring.Length; i++)
            {
                for (int j = i + 1; j < arring.Length; j++)
                {
                    match[i] = new Game(arring[i], arring[j]);
                    match[i].playGame();
                    match[i].winmatch();
                    match[i].playGameResult();
                    arring[i].Cardcount();//纪录每次比赛的红牌黄牌数
                    arring[j].Cardcount();
                }
            }
            //排序
            for (int i = 0; i < arring.Length; i++)
            {
                Team swap;
                for (int j = i + 1; j < arring.Length; j++)
                {
                    if (arring[i].sumCount == arring[j].sumCount)
                    {
                        if (arring[i].finishGoalCount < arring[j].finishGoalCount)
                        {
                            swap = arring[i];
                            arring[i] = arring[j];
                            arring[j] = swap;
                        }
                    }
                    if (arring[i].sumCount < arring[j].sumCount)
                    {
                        swap = arring[i];
                        arring[i] = arring[j];
                        arring[j] = swap;
                    }
                    if (arring[i].sumCount == arring[j].sumCount && arring[i].finishGoalCount == arring[j].finishGoalCount)
                    {
                        Random random = new Random();
                        if (random.Next(1, 100) < 50)
                        {
                            swap = arring[i];
                            arring[i] = arring[j];
                            arring[j] = swap;
                        }
                    }

                }
            }
        }
    }
}
