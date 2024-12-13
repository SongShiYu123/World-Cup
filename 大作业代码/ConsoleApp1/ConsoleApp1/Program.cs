// See https://aka.ms/new-console-template for more information
using System.Buffers;
using System.ComponentModel;
using System.Numerics;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //将venue数据读取出来
            List<Venue> venueList = new List<Venue>();
            string file = "venues.txt";
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] arr = line.Split(',');
                        int.TryParse(arr[1], out int number1);
                        int.TryParse(arr[2], out int number2);
                        float.TryParse(arr[3], out float number3);
                        venueList.Add(new Venue(arr[0], number1, number2, number3));
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("File path is wrong");
            }
            //将driver数据读取出来
            List<Driver> drivers = new List<Driver>();
            file = "driver.txt";
            try
            {
                using (StreamReader sr1 = new StreamReader(file))
                {
                    string line1;
                    while ((line1 = sr1.ReadLine()) != null)
                    {
                        string[] arr1 = line1.Split(',');
                        int.TryParse(arr1[1], out int number1);
                        bool.TryParse(arr1[3], out bool number2);
                        int.TryParse(arr1[4], out int number3);
                        drivers.Add(new Driver(arr1[0], number1, arr1[2], number2, number3));
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("File path is wrong");
            }
            //输入比赛次数
            Console.WriteLine("Grand Prix championship begin!");
            Console.WriteLine("=====================================");
            Console.WriteLine();
            Console.Write("please input the number of matches:");  
            string count = Console.ReadLine();
            Console.WriteLine();
            CheckMathchCount checkMathchCount = new CheckMathchCount();
            int sum = checkMathchCount.checkMathchCount(count);//总比赛次数
            //开始比赛
            Random random = new Random();
            HashSet<int> uniqueNumbers = new HashSet<int>();
            while (uniqueNumbers.Count < sum) //记录随机所挑选的场地
            {
                int n = random.Next(0, 8);
                uniqueNumbers.Add(n);
            }
            // 将 HashSet 转换为数组
            int[] uniqueArray = new int[uniqueNumbers.Count];
            uniqueNumbers.CopyTo(uniqueArray);
            int gameSum = 0;//记录比赛次数
            while(gameSum<sum)//总比赛
            {
                SumGame sumGame = new SumGame();
                sumGame.SumGame1(ref gameSum, drivers, venueList, uniqueArray);               
            }
            drivers.Sort((drivers1, drivers2) =>//
            {
                int result = drivers2.points.CompareTo(drivers1.points);
                return result;
            });
            for(int i = 0;i< drivers.Count;i++)
            {
                Console.WriteLine("{0} points is {1}", drivers[i].driverName, drivers[i].points);
            }
            Console.WriteLine("Champion is {0}", drivers[0].driverName);
            //将信息写入文件
            try
            {
                using (StreamWriter write = new StreamWriter(file))
                {
                    for (int i = 0; i < drivers.Count; i++)
                    {
                        string content = $"{drivers[i].driverName},{drivers[i].ranking},{drivers[i].skills},true,0";
                        write.WriteLine(content);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("File path is wrong");
            }
        }
    }
}
