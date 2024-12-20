﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Game
    {
        public Team[] matchteam { get; set; }
        public Game()
        {
            matchteam = new Team[2];
        }
        public Game(Team team1, Team team2)
        {
            matchteam = new Team[2];
            matchteam[0] = team1;
            matchteam[1] = team2;
        }
        //模拟进球
        public void playGame()
        {
            matchteam[0].presentCount++;
            matchteam[1].presentCount++;
            if (matchteam[0].ranking > matchteam[1].ranking)
            {
                Random random = new Random();
                //球队1总进球数
                matchteam[0].finishGoalCount = random.Next(0, 5 + random.Next(0, 2));
                matchteam[0].sumFinishGoalCount = matchteam[0].sumFinishGoalCount + matchteam[0].finishGoalCount;
                //计算第一个队伍每个球员的进球数
                matchteam[0].player1.goal = random.Next(0, matchteam[0].finishGoalCount);
                matchteam[0].player1.sumGoal = matchteam[0].player1.sumGoal + matchteam[0].player1.goal;
                matchteam[0].player2.goal = matchteam[0].finishGoalCount - matchteam[0].player1.goal;
                matchteam[0].player2.sumGoal = matchteam[0].player2.sumGoal + matchteam[0].player2.goal;
                //球队2总进球数
                matchteam[1].finishGoalCount = random.Next(0, 5 - (matchteam[0].ranking - matchteam[1].ranking) + random.Next(0, 2));
                matchteam[1].sumFinishGoalCount = matchteam[1].sumFinishGoalCount + matchteam[1].finishGoalCount;
                //计算第二个队伍每个球员的进球数
                matchteam[1].player1.goal = random.Next(0, matchteam[1].finishGoalCount);
                matchteam[1].player1.sumGoal = matchteam[1].player1.sumGoal + matchteam[1].player1.goal;
                matchteam[1].player2.goal = matchteam[1].finishGoalCount - matchteam[1].player1.goal;
                matchteam[1].player2.sumGoal = matchteam[1].player2.sumGoal + matchteam[1].player2.goal;
            }
            else
            {
                Random random = new Random();
                //球队2总进球数
                matchteam[1].finishGoalCount = random.Next(0, 5 + random.Next(0, 2));//每局进球数
                matchteam[1].sumFinishGoalCount = matchteam[1].sumFinishGoalCount + matchteam[1].finishGoalCount;
                //计算第二个队伍每个球员的进球数
                matchteam[1].player1.goal = random.Next(0, matchteam[1].finishGoalCount);
                matchteam[1].player1.sumGoal = matchteam[1].player1.sumGoal + matchteam[1].player1.goal;
                matchteam[1].player2.goal = matchteam[1].finishGoalCount - matchteam[1].player1.goal;
                matchteam[1].player2.sumGoal = matchteam[1].player2.sumGoal + matchteam[1].player2.goal;
                //球队1总进球数
                matchteam[0].finishGoalCount = random.Next(0, 5 - (matchteam[1].ranking - matchteam[0].ranking) + random.Next(0, 2));
                matchteam[0].sumFinishGoalCount = matchteam[0].sumFinishGoalCount + matchteam[0].finishGoalCount;
                //计算第一个队伍每个球员的进球数
                matchteam[0].player1.goal = random.Next(0, matchteam[0].finishGoalCount);
                matchteam[0].player1.sumGoal = matchteam[0].player1.sumGoal + matchteam[0].player1.goal;
                matchteam[0].player2.goal = matchteam[0].finishGoalCount - matchteam[0].player1.goal;
                matchteam[0].player2.sumGoal = matchteam[0].player2.sumGoal + matchteam[0].player2.goal;
            }
        }
        //判断哪个球队赢了
        public void winmatch()
        {
            if (matchteam[0].finishGoalCount > matchteam[1].finishGoalCount)
            {
                matchteam[0].winCount++;
                matchteam[1].lossCount++;
                matchteam[0].sumCount = matchteam[0].sumCount + 3;
            }
            else if (matchteam[0].finishGoalCount < matchteam[1].finishGoalCount)
            {
                matchteam[1].winCount++;
                matchteam[0].lossCount++;
                matchteam[1].sumCount = matchteam[1].sumCount + 3;
            }
            else if (matchteam[0].finishGoalCount == matchteam[1].finishGoalCount)
            {
                matchteam[0].drawCount++;
                matchteam[0].sumCount++;
                matchteam[1].drawCount++;
                matchteam[1].sumCount++;
            }
        }
        public void playPenaltyShootOut()
        {
            Console.WriteLine("The penalty shootout begins to run:");
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                if (random.Next(0, 100) > 50)  //模拟进球概率为50%
                {
                    matchteam[0].inputDoor++;
                    Console.WriteLine("{0} scored {1} penalty kick", matchteam[0].countryName, i);
                }
                else
                {
                    Console.WriteLine("{0} missed penalty kick {1}", matchteam[0].countryName, i);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (random.Next(0, 100) > 50)  //模拟进球概率为50%
                {
                    matchteam[1].inputDoor++;
                    Console.WriteLine("{0} scored {1} penalty kick", matchteam[1].countryName, i);
                }
                else
                {
                    Console.WriteLine("{0} missed penalty kick {1}", matchteam[1].countryName, i);
                }
            }
            int count = 0;
            while (matchteam[0].inputDoor == matchteam[1].inputDoor)
            {
                Console.Write("First round:");
                if (random.Next(0, 100) > 50)
                {
                    Console.Write("{0} scored {1} penalty kick", matchteam[0].countryName, count);
                    matchteam[0].inputDoor++;
                }
                else if (random.Next(0, 100) > 50)
                {
                    matchteam[1].inputDoor++;
                    Console.WriteLine("{0} scored {1} penalty kick", matchteam[0].countryName, count);
                }
                if(matchteam[0].inputDoor> matchteam[1].inputDoor)
                {
                    Console.Write("{0} scored {1} penalty kick,{3} missed penalty kick {4}", matchteam[0].countryName, count, matchteam[1].countryName,);
                }
                count++;
            }
        }
        //展示结果
        public void playGameResult()
        {
            Console.WriteLine("Competition is:");
            Console.WriteLine("{0,-20}{1,5} vs {2,-20}{3,5}", matchteam[0].countryName, matchteam[0].finishGoalCount, matchteam[1].finishGoalCount, matchteam[1].countryName);
            Console.WriteLine("Issued cards:");
            Console.WriteLine("{0,-20}{1,5}yellow card{2,20}red card", matchteam[0].countryName, matchteam[0].yellow, matchteam[0].red);
            Console.WriteLine("{0,-20}{1,5}yellow card{2,20}red card", matchteam[1].countryName, matchteam[1].yellow, matchteam[1].red);
        }
    }
}
