using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class OptionE
    {
        public void ExecuteOptionE(Team[]arring)
        {
            string winname = "";
            int max = 0;
            for (int i = 0; i < arring.Length; i++)
            {
                if (arring[i].player1.goal > max)
                    max = arring[i].player1.goal;
                if (arring[i].player2.goal > max)
                    max = arring[i].player2.goal;
            }
            for (int j = 0; j < arring.Length; j++)
            {
                if (arring[j].player1.goal == max)
                {
                    winname = arring[j].player1.name; //把射球数最高的成员名字赋值
                    Console.WriteLine("Golden Boot Award: {0}", winname);
                }
                if (arring[j].player2.goal == max)
                {
                    winname = arring[j].player2.name;
                    Console.WriteLine("Golden Boot Award: {0}", winname);
                }
            }
        }
        public void ExecuteOptionE1(Team[] arring)
        {
            int max1 = arring[0].fairPlayScore;
            for (int i = 0; i < arring.Length; i++)
            {
                if (arring[i].fairPlayScore < max1)
                {
                    max1 = arring[i].fairPlayScore;
                }
            }
            for (int j = 0; j < arring.Length; j++)
            {
                if (arring[j].fairPlayScore == max1)
                {
                    Console.WriteLine("Fair Play Award:{0}", arring[j].countryName);
                }
            }
        }
    }
}
