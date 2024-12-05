using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Team
    {
        private static Random random = new Random();
        public Player player1;
        public Player player2;
        public string countryName { set; get; }
        public int ranking { set; get; }
        public int yellow { set; get; }
        public int red { set; get; }
        public int presentCount { set; get; }
        public int winCount { set; get; }
        public int lossCount { set; get; }
        public int drawCount { set; get; }
        public int finishGoalCount { set; get; }
        public int sumCount { set; get; }   //总积分
        public int inputDoor { get; set; }//点球时射门次数
        public int fairPlayScore { set; get; }
        public int sumFinishGoalCount { set; get; }
        public Team(string Name, int Ranking)
        {
            countryName = Name;
            ranking = Ranking;
            yellow = 0;
            red = 0;
            presentCount = 0;
            winCount = 0;
            lossCount = 0;
            drawCount = 0;
            finishGoalCount = 0;
            sumCount = 0;
            inputDoor = 0;
            fairPlayScore = 0;
            sumFinishGoalCount = 0;
        }
        //计算每场比赛每个队伍的红牌和黄牌数
        public void Cardcount()
        {
            if (random.Next(0, 100) > 95)
            {
                red = red + 1;
                fairPlayScore = fairPlayScore + 2;
            }
            if (random.Next(0, 100) < 75)
            {
                yellow = yellow + 1;
                fairPlayScore = fairPlayScore + 1;
            }
        }
    }
}
