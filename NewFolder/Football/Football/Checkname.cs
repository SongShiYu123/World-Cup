using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp18
{
    public class Checkname
    {
        //判断第一个名字对不对
        public string checkedname1(string countryName)
        {
            Console.WriteLine("Please input player1 name");
            string name1 = Console.ReadLine();
            string pattern = @"^(?!-)[A-Za-z-]+(?<!-)$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(name1) && name1.Split('-').Length == 2 && name1.Length < 20)
            {
                Console.WriteLine("The {0} information you entered is correct", name1);
            }
            else
            {
                Console.WriteLine("The {0} information you entered is incorrect, please input again", name1);
                name1 = Console.ReadLine();
                if (regex.IsMatch(name1) && name1.Split('-').Length == 2 && name1.Length < 20)
                {
                    Console.WriteLine("The {0} information you entered is correct", name1);
                }
                else
                {
                    Console.WriteLine("The {0} information you entered is incorrect", name1);
                    name1 = $"player-1-{countryName}";
                    Console.WriteLine("Assign default name:{0} ", name1);
                }
            }
            return name1;
        }
        //判断第二个名字对不对
        public string checkedname2(string countryName, string name1)
        {
            Console.WriteLine("Please input player2 name");
            string name2 = Console.ReadLine();
            string pattern = @"^(?!-)[A-Za-z-]+(?<!-)$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(name2) && name2.Split('-').Length == 2 && name2.Length < 20 && name2 != name1)
            {
                Console.WriteLine("The {0} information you entered is correct", name2);
            }
            else
            {
                Console.WriteLine("The {0} information you entered is incorrect, please input again", name2);
                name1 = Console.ReadLine();
                if (regex.IsMatch(name2) && name2.Split('-').Length == 2 && name2.Length < 20 && name2 != name1)
                {
                    Console.WriteLine("The {0} information you entered is correct", name2);
                }
                else
                {
                    Console.WriteLine("The {0} information you entered is incorrect", name2);
                    name2 = $"player-2-{countryName}";
                    Console.WriteLine("Assign default name:{0} ", name2);
                }
            }
            return name2;
        }
    }
}
