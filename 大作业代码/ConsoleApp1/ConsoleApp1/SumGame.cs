using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SumGame
    {
        public void SumGame1(ref int gameSum,List<Driver>drivers,List<Venue> venueList, int[] uniqueArray)
        {
            Console.WriteLine("The {0} game officially begins", gameSum + 1);
            Console.WriteLine("------------------------------");
            Console.WriteLine("The venue for the {0} match is {1}", gameSum + 1, venueList[uniqueArray[gameSum]].venueName);
            Console.WriteLine();
            Game game = new Game(drivers, venueList[uniqueArray[gameSum]]);
            game.Game1(drivers, venueList[uniqueArray[gameSum]]);
            gameSum++;
            //改变排名
            for (int i = 0; i < drivers.Count; i++)
            {
                drivers[0].ranking = 1;
                drivers[1].ranking = 2;
                drivers[2].ranking = 3;
                drivers[3].ranking = 4;
            }
            //输出各个选手的总用时
            Console.WriteLine("Here is the ranking of this player time:");
            for (int i = 0; i < drivers.Count; i++)
            {
                Console.WriteLine("{0}:{1}  ", drivers[i].driverName, drivers[i].sumTime);
            }
            //输出排名
            Console.WriteLine("Here is the ranking of this game:");
            for (int i = 4; i < drivers.Count; i++)
            {
                drivers[i].ranking = 5;
            }
            for (int i = 0; i < drivers.Count; i++)
            {
                Console.Write("{0}:{1}  ", drivers[i].driverName, drivers[i].ranking);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
