using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rain
    {
        private Random random = new Random();
        public void Rainprobility(List<Driver> drivers,float possibility)
        {
            int judg = 0;//判断是否下雨
            int a = random.Next(0, 100);
            if(a<possibility*100)
            {
                judg++;
                Console.WriteLine("Weather is rainning");
                Console.WriteLine("-------------------");
            }           
            for(int i = 0;i < drivers.Count;i++)
            {
                int b = random.Next(0, 100);//判断是否换轮胎
                if (b<50)
                {
                    drivers[i].type = "Rainy tires";
                    drivers[i].sumTime = drivers[i].sumTime + 10;
                    Console.WriteLine("-{0} replace rainy tires,time increse 10", drivers[i].driverName);
                }
            }
            for (int i = 0; i < drivers.Count; i++)
            {
                if(judg == 1 && drivers[i].type == "Dry tires")
                {
                    drivers[i].sumTime = drivers[i].sumTime + 5;
                    Console.WriteLine("The rain caused the {0} time to increase by five seconds", drivers[i].driverName);
                }
            }
        }
    }
}
