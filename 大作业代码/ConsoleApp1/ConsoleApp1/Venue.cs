using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Venue
    {
        public string venueName { set; get; }
        public int lapCount { set; get; }
        public int vace { set; get; }
        public float rainProbability { set; get; }
        public Venue(string venueName, int lapcount,int vace,float rainProbability)
        {
            this.venueName = venueName;
            this.lapCount = lapcount;
            this.vace = vace;
            this.rainProbability = rainProbability;
        }
    }
}
