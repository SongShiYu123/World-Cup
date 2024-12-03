// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp18
{
    class MySample
    {
        static void Main(string[] args)
        {
            try
            {
                string file = "..\\..\\..\\teams.txt";
                StreamReader sr = new StreamReader(file);
                string line;
                line = sr.ReadLine();
                string[] arr = line.Split(' ');
                int countryCount = 0; // 记录球队有多少
                while (countryCount < arr.Length)
                {
                    countryCount++;
                }
                countryCount = countryCount / 2;
                Team[] arring = new Team[countryCount]; // 初始化数组大小

                Player Empty = new Player(); // 用来判断球员名字是否合理
                                             // 各个国家的排名
                CountryRanking countryRanking = new CountryRanking();
                countryRanking.Ranking(countryCount, arring, arr, Empty);
                //输出菜单
                MMnu mMnu = new MMnu();
                mMnu.menu();
                int i = 0;
                int j = 0;
                int matchCount = 1;//比赛数量
                for (i = 1; i < countryCount; i++)
                {
                    matchCount = matchCount * i;
                }
                Game[] match = new Game[matchCount];
                Console.Write("Please input your otion:");
                string option = Console.ReadLine();
                //假设用户第一次输入X
                while (option == "X")
                {
                    Console.WriteLine("input is wrong,please input again");
                    mMnu.menu();
                    option = Console.ReadLine();
                }
                int count = 0;//纪录是否比完初赛
                              //初赛比赛结果
                while (option != "X")
                {
                    int max1 = 0;//记录最佳射手
                    if (option == "A")
                    {
                        OptionA a = new OptionA();
                        a.ExecuteOptionA(ref count, arring, match);
                    }
                    if (option == "B" && count > 0)
                    {
                        OptionB b = new OptionB();
                        b.ExecuteOptionB(ref count, arring, match, Empty);
                    }
                    else if (option == "B" && count == 0)
                    {
                        Console.WriteLine("It is wrong to execute the final before the preliminary round");
                    }
                    if (option == "C")
                    {
                        Console.WriteLine("{0,15}{1,15}{2,15}{3,15}{4,15}{5,15}{6,15}", "Played", "Won", "Lost", "Draw", "Goals", "Points", "FairPlayScore");
                        i = 0;
                        while (i < arring.Length)
                        {
                            Console.WriteLine("{0,-10}{1,5}{2,15}{3,15}{4,15}{5,15}{6,15}{7,15}", arring[i].countryName, arring[i].presentCount, arring[i].winCount, arring[i].lossCount, arring[i].drawCount, arring[i].finishGoalCount, arring[i].sumCount, arring[i].fairPlayScore);
                            i++;
                        }
                    }
                    if (option == "D")
                    {
                        for (i = 0; i < arring.Length; i++)
                        {
                            Console.WriteLine("{0,-15}{1,10}{2,10}", arring[i].player1.name, arring[i].countryName, arring[i].player1.goal);
                            Console.WriteLine("{0,-15}{1,10}{2,10}", arring[i].player2.name, arring[i].countryName, arring[i].player2.goal);
                        }
                    }
                    if (option == "E" && count > 0)
                    {
                        Console.WriteLine("Football World Cup Winner:{0}", arring[0].countryName);
                        //寻找射球数最多的球员
                        OptionE optionE = new OptionE();
                        optionE.ExecuteOptionE(arring);
                    }
                    if (option == "E" && count > 0)
                    {
                        OptionE optionE = new OptionE();
                        optionE.ExecuteOptionE1(arring);
                    }

                    if ((option != "A" && option != "B" && option != "C" && option != "D" && option != "E" && option != "X") || (option == "E" && count == 0))
                    {
                        mMnu.menu();
                        Console.WriteLine("The information you entered is incorrect,please input again;");
                    }
                    Console.WriteLine("Please input your option:");
                    option = Console.ReadLine();
                    if (option == "X") //将E的内容写进文档里
                    {
                        OptionX optionX = new OptionX();
                        optionX.ExecuteOptionX(arring);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("File path is wrong");
            }

        }
    }
}




