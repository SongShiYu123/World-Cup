using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CheckMathchCount
    {
        public int checkMathchCount(string input)
        {
            string panduan = @"^[3-5]$";
            Regex regex = new Regex(panduan);
            while(!regex.IsMatch(input))
            {
                Console.WriteLine("Input is wrong,please input a number from three to five");
                input  = Console.ReadLine();
                Console.WriteLine();
            }
            int.TryParse(input, out int number);
            return number;
        }
    }
}
