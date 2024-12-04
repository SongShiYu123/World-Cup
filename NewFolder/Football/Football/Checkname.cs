﻿using System;
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
        public string checkedname1(string name,string countryName,int number)
        {
            Console.WriteLine("Please input {0} player{1} name",countryName,number);
            string name1 = Console.ReadLine();
            string pattern = @"^(?!-)[A-Za-z-]+(?<!-)$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(name1) && name1.Split('-').Length == 2 && name1.Length < 20&&name1!=name)
            {
                Console.WriteLine("The {0} information you entered is correct", name1);
            }
            else
            {
                Console.WriteLine("The {0} information you entered is incorrect, please input again", name1);
                name1 = Console.ReadLine();
                if (regex.IsMatch(name1) && name1.Split('-').Length == 2 && name1.Length < 20 && name1 != name)
                {
                    Console.WriteLine("The {0} information you entered is correct", name1);
                }
                else
                {
                    Console.WriteLine("The {0} information you entered is incorrect", name1);
                    name1 = $"player-{number}-{countryName}";
                    Console.WriteLine("Assign default name:{0} ", name1);
                }
            }
            return name1;
        }       
    }
}
