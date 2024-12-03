// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
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
                //读取文件内容
                string file = "..\\..\\..\\teams.txt";
                StreamReader sr = new StreamReader(file);
                string line;
                line = sr.ReadLine();
                string[] arr = line.Split(' ');
                ArrayList arring = new ArrayList();
                //给每个团队的内容赋值
                List<Team> arrings = new List<Team>();
                for (int i = 0; i < arr.Length; i++)
                {
                    arrings.Add(new Team(arr[i], int.Parse(arr[i + 1])));
                    i = i + 1;
                }
                for (int i = 0; i < arrings.Count; i++)
                {
                    Checkname checkname = new Checkname();
                    arrings[i].player1 = new Player();
                    arrings[i].player2 = new Player();
                    arrings[i].player1.name = checkname.checkedname1(arrings[i].countryName);
                    arrings[i].player2.name = checkname.checkedname2(arrings[i].countryName, arrings[i].player1.name);
                    arrings[i].player1.goal = 0;
                    arrings[i].player2.goal = 0;
                }
                // 记录球队有多少
                int countryCount = 0;
                while (countryCount < arr.Length)
                {
                    countryCount++;
                }
                countryCount = countryCount / 2;
                //输出菜单
                MMnu mMnu = new MMnu();
                mMnu.menu();
                int matchCount = 1;//比赛数量
                for (int i = 1; i < countryCount; i++)
                {
                    matchCount = matchCount * i;
                }
                Game[] match = new Game[matchCount];
                Console.Write("Please input your otion:");
                string option = Console.ReadLine();
                int count = 0;//纪录是否比完初赛
                int count1 = 0;//记录是否比完决赛
                while (option != "X")
                {
                    int max1 = 0;//记录最佳射手
                    switch (option)

                    {
                        case "A":
                            if (count > 0)
                            {
                                Console.WriteLine("The information you entered is incorrect,please input again;");
                            }
                            else
                            {
                                OptionA a = new OptionA();
                                a.ExecuteOptionA(arrings, match);
                                a.ExecuteOptionA1(arrings);
                                count++;
                            }
                            mMnu.menu();
                            break;
                        case "B":
                            if (count > 0 && count1 == 0)
                            {
                                count1++;
                                OptionB b = new OptionB();
                                b.ExecuteOptionB(arrings, match);
                            }
                            else if ((option == "B" && count == 0) || count1 > 0)
                            {
                                Console.WriteLine("The information you entered is incorrect,please input again;");
                            }
                            mMnu.menu();
                            break;
                        case "C":
                            {
                                Console.WriteLine("{0,15}{1,15}{2,15}{3,15}{4,15}{5,15}{6,15}", "Played", "Won", "Lost", "Draw", "Goals", "Points", "FairPlayScore");
                                int i = 0;
                                while (i < arrings.Count)
                                {
                                    Console.WriteLine("{0,-10}{1,5}{2,15}{3,15}{4,15}{5,15}{6,15}{7,15}", arrings[i].countryName, arrings[i].presentCount, arrings[i].winCount, arrings[i].lossCount, arrings[i].drawCount, arrings[i].finishGoalCount, arrings[i].sumCount, arrings[i].fairPlayScore);
                                    i++;
                                }
                            }
                            mMnu.menu();
                            break;
                        case "D":
                            for (int i = 0; i < arrings.Count; i++)
                            {
                                Console.WriteLine("{0,-15}{1,10}{2,10}", arrings[i].player1.name, arrings[i].countryName, arrings[i].player1.goal);
                                Console.WriteLine("{0,-15}{1,10}{2,10}", arrings[i].player2.name, arrings[i].countryName, arrings[i].player2.goal);
                            }
                            mMnu.menu();
                            break;
                        case "E":
                            if (count > 0)

                            {
                                Console.WriteLine("Football World Cup Winner:{0}", arrings[0].countryName);
                                //寻找射球数最多的球员
                                OptionE optionE = new OptionE();
                                optionE.ExecuteOptionE(arrings);
                                optionE.ExecuteOptionE1(arrings);
                            }
                            else
                            {
                                Console.WriteLine("The information you entered is incorrect, please input again;");
                            }
                            mMnu.menu();
                            break;
                        default:
                            mMnu.menu();
                            Console.WriteLine("The information you entered is incorrect, please input again;");
                            break;
                    }
                    Console.WriteLine("Please input your option:");
                    option = Console.ReadLine();
                    if (option == "X") //将E的内容写进文档里
                    {
                        OptionX optionX = new OptionX();
                        optionX.ExecuteOptionX(arrings);
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




