using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Driver
    {
        public string driverName { get; set; }
        public int ranking { get; set; }
        public string skills { get; set; }
        public bool qualifications { get; set; }
        public int sumTime { get; set; }
        public int points { get; set; }
        public string type { get; set; }
        public Driver(string driverName,int ranking,string skills,bool qualifications,int sumTime)
        {
            this.driverName = driverName;
            this.ranking = ranking;
            this.skills = skills;
            this.qualifications = qualifications;
            this.sumTime = sumTime;
            this.points = 0;
            type = "Dry tires";
        }
    }
}
