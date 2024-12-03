using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class OptionB
    {
        public void ExecuteOptionB(List<Team> arrings, Game[] match)
        {
            Game game = new Game(arrings[0], arrings[1]);
            game.playGame();
            game.winmatch();
            arrings[0].Cardcount();//纪录每次比赛的红牌黄牌数
            arrings[1].Cardcount();
            if (arrings[0].finishGoalCount < arrings[1].finishGoalCount)
            {
                Team swap;
                swap = arrings[0];
                arrings[0] = arrings[1];
                arrings[1] = swap;
            }
            if (arrings[0].finishGoalCount == arrings[1].finishGoalCount)
            {
                game.playPenaltyShootOut();
                if (arrings[0].inputDoor < arrings[1].inputDoor)
                {
                    Team swap;
                    swap = arrings[0];
                    arrings[0] = arrings[1];
                    arrings[1] = swap;
                    arrings[0].winCount++;
                    arrings[1].lossCount++;
                }
                else
                {
                    arrings[0].winCount++;
                    arrings[1].lossCount++;
                }
            }
            game.playGameResult();
        }
    }
}
