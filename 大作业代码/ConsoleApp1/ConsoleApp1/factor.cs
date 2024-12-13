using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Factor
    {
        private Random random = new Random();
        public  int factor(int time,int n,Driver driver,Venue venue)//n是判断第几圈
        {
            int increase = 0;//判断是否发生了小型事故
            //技能减时
            int a1 = random.Next(1, 9);
            int a2 = random.Next(10, 21);
            //事故加时
            int b = random.Next(0, 100);
            switch(driver.skills)
            {
                case "breaking":
                    Console.WriteLine("-{0} activate brake skills,time decrease {1} seconds", driver.driverName, a1);
                    time = time - a1;
                    break;
                case "cornering":
                    Console.WriteLine("-{0} activate corner skills,time decrease {1} seconds", driver.driverName, a1);
                    time = time - a2;
                    break;
                case "overtaking":
                    Console.WriteLine("-{0} activate overtake skills,time decrease {1} seconds", driver.driverName, a2);
                    time = time - a2;
                    break;

            }
            if (b < 1)
            {
                increase++;
                Console.WriteLine("-{0} car appears not repair accident", driver.driverName);
                driver.qualifications = false;
            }
            else if (b < 3 && increase == 0)
            {
                increase++;
                Console.WriteLine("-{0} car appears big accident,time increase {1} seconds", driver.driverName, 120);
                time = time + 120;
            }
            else if (b < 5 && increase == 0)
            {
                increase++;
                Console.WriteLine("-{0} car appears small accident,time increase {1} seconds", driver.driverName,20);
                time = time + 20;
            }
            return time;
        }
    }
}
