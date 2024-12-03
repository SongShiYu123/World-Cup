using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp18
{
    internal class CountryRanking
    {
        public void Ranking(int countryCount, Team[] arring, string[]arr,Player Empty)
        {
            int i = 0; // 给所有国家赋值
            int j = 0;
            int x = 0;
            while (i < countryCount)
            {
                arring[i] = new Team(); // 初始化数组元素
                arring[i].countryName = arr[j];
                arring[i].ranking = int.Parse(arr[j + 1]);
                // 初始化每个球队的信息
                Console.WriteLine("Please input {0} player1 name", arring[i].countryName);
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
                        name1 = "player-1-Ghana";
                        Console.WriteLine("Assign default name:{0} ", name1);
                    }
                }
                Console.WriteLine("Please input {0} player2", arring[i].countryName);
                string name2 = Console.ReadLine();
                while(name1 == name2&&x<1)
                {
                    Console.WriteLine("The {0} information you entered is incorrect", name2);
                    name2 = Console.ReadLine();
                    x++;
                }
                if(x==1&&name2 == name1)
                {
                    Console.WriteLine("The {0} information you entered is incorrect", name2);
                    name2 = "player-2-Ghana";
                    Console.WriteLine("Two input errors using default name:{0} ", name2);
                }
                if(x==0)
                {
                    pattern = @"^(?!-)[A-Za-z-]+(?<!-)$";
                    regex = new Regex(pattern);

                    if (regex.IsMatch(name2) && name2.Split('-').Length == 2&&name2!=name1&&name2.Length<20)
                    {
                        Console.WriteLine("The {0} information you entered is correct", name2);
                    }
                    else
                    {
                        Console.WriteLine("The {0} information you entered is incorrect, please input again", name2);
                        name2 = Console.ReadLine();

                        if (regex.IsMatch(name2) && name2.Split('-').Length == 2&&name2!=name1&&name2.Length<20)
                        {
                            Console.WriteLine("The {0} information you entered is correct", name2);
                        }
                        else
                        {
                            Console.WriteLine("The {0} information you entered is incorrect", name2);
                            name2 = "player-2-Ghana";
                            Console.WriteLine("Assign default name:{0} ", name2);
                        }
                    }
                }
                if(x==1&&name2!=name1&& name2 != "player-1-Ghana"&&name2.Length<20)
                {
                    pattern = @"^(?!-)[A-Za-z-]+(?<!-)$";
                    regex = new Regex(pattern);

                    if (regex.IsMatch(name2) && name2.Split('-').Length == 2&&name2.Length<20)
                    {
                        Console.WriteLine("The {0} information you entered is correct", name2);
                    }
                    else
                    {
                        Console.WriteLine("The {0} information you entered is incorrect",name2);
                        name2 = "player-2-Ghana";
                        Console.WriteLine("Two input errors using default name:{0} ", name2);
                    }
                }
                else if (x == 1 && name2 != name1 && name2 != "player-1-Ghana" && name2.Length > 20)
                {
                    Console.WriteLine("The {0} information you entered is incorrect", name2);
                    name2 = "player-2-Ghana";
                    Console.WriteLine("Two input errors using default name:{0} ", name2);
                }
                arring[i].player1 = new Player(name1, arring[i].countryName, 0);
                arring[i].player2 = new Player(name2, arring[i].countryName, 0);
                i++;
                j = j + 2;
            }
        }
    }
}
