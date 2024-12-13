using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Game
    {
        private Random random = new Random();
        public List<Driver> drivers { get; set; }
        public Venue venue { get; set; }
        public Game(List<Driver> drivers, Venue venue)
        {
            this.drivers = drivers;
            this.venue = venue;
        }
        public void Game1(List<Driver>drivers,Venue venue)
        {
            Factor factor1 = new Factor();
            drivers.Sort((drivers1, drivers2) =>//按排名排个序
            {
                int result = drivers1.ranking.CompareTo(drivers2.ranking);
                return result;
            });
            //开始比赛，先从一个车一圈上开始写
            int n = 1;//记录第几圈
            drivers[0].sumTime = venue.vace;
            drivers[1].sumTime = venue.vace + 3;
            drivers[2].sumTime = venue.vace + 5;
            drivers[3].sumTime = venue.vace + 7;
            for (int i = 4; i < drivers.Count; i++)
            {
                drivers[i].sumTime = venue.vace + 10;
            }
            while (n <= venue.lapCount)//比完全部圈
            {
                Console.WriteLine("The {0} round of the competition has officially begun:",n);
                if(n==2)
                {
                    Rain rain = new Rain();
                    rain.Rainprobility(drivers,venue.rainProbability);
                }
                for(int i = 0;i<drivers.Count;i++)
                {
                    drivers[i].sumTime = factor1.factor(drivers[i].sumTime, n, drivers[i], venue);
                }               
                Sort sort = new Sort();
                sort.Sort1(drivers);
                Console.WriteLine();
                Console.WriteLine("The name of the leading driver in the {0} round is {1},time is {2}", n,drivers[0].driverName, drivers[0].sumTime);
                Console.WriteLine("----------------------------");
                for (int i = 0; i < drivers.Count; i++)
                {
                    drivers[i].sumTime = drivers[i].sumTime + venue.vace;
                }
                n++;
                Console.WriteLine();
            }
            drivers[0].points = drivers[0].points + 8;
            drivers[1].points = drivers[1].points + 5;
            drivers[2].points = drivers[2].points + 3;
            drivers[3].points = drivers[3].points + 1;
        }
    }
}
