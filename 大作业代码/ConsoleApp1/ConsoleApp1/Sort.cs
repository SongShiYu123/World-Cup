using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Sort
    {
        private Random random = new Random();
        public void Sort1(List<Driver>drivers)
        {
            drivers.Sort((drivers1, drivers2) =>//按排名排个序
            {
                int result = drivers2.qualifications.CompareTo(drivers1.qualifications);
                if (result == 0)
                {
                    result = drivers1.sumTime.CompareTo(drivers2.sumTime);
                    if (result == 0)
                    {
                        result = random.Next(1, 100) < 50 ? -1 : 1;
                    }
                }
                return result;
            });
        }
    }
}
