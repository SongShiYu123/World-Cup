using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class OptionB
    {
        public void ExecuteOptionB(ref int count, Team[] arring, Game[]match,Player Empty)
        {
            Game game = new Game(arring[0], arring[1]);
            game.playGame();
            game.winmatch();
            arring[0].Cardcount();//纪录每次比赛的红牌黄牌数
            arring[1].Cardcount();
            if (arring[0].finishGoalCount < arring[1].finishGoalCount)
            {
                Team swap;
                swap = arring[0];
                arring[0] = arring[1];
                arring[1] = swap;
            }
            if (arring[0].finishGoalCount== arring[1].finishGoalCount)
            {
                game.playPenaltyShootOut();
                if (arring[0].inputDoor < arring[1].inputDoor)
                {
                    Team swap;
                    swap = arring[0];
                    arring[0] = arring[1];
                    arring[1] = swap;
                    arring[0].winCount++;
                    arring[1].lossCount++;
                }
                else
                {
                    arring[0].winCount++;
                    arring[1].lossCount++;
                }
            }
            game.playGameResult();
        }
    }
}
