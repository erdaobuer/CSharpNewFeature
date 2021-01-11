using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace CSharp6新特征
{
    internal class Program
    {
        private static double PI = 3.1415;

        private static void Main(string[] args)
        {
            //NewFeature1();
            //var age = NewFeature4(new Student()
            //{
            //    Age = 1,
            //    Birthday = Convert.ToDateTime("2018-03-23")
            //});
            //var age1 = NewFeature4(null);
            //Console.WriteLine($"My Age is {age1:d2} ");

            //NewFeature5();
            Console.WriteLine(Sin(PI / 2));
            Console.WriteLine(Sin(PI));
            Console.WriteLine(Sin(PI * 3 / 2));
        }

        public static void NewFeature1()
        {
            int sId = 23;
            string sq1 = $"select *from AAA where ID={sId,10}";//前面加10个空格，然后以三位输出
            string sq2 = $"select *from AAA where ID={sId:d3}";//前面加10个空格，然后以三位输出
            string sq3 = $"select *from AAA where ID={sId,10:d3}";//前面加10个空格，然后以三位输出
            Console.WriteLine(sq1);
            Console.WriteLine(sq2);
            Console.WriteLine(sq3);
        }

        public static void NewFeature2(string name)
        {
            Console.WriteLine($"My name is{nameof(name)}");
            Console.WriteLine($"My name is{nameof(name)}");
            Console.WriteLine($"My name is{nameof(name)}");
            Console.WriteLine($"My name is{nameof(name)}");
        }

        public static int NewFeature3(Student stu) => stu.Age + 100;

        public static int NewFeature4(Student stu)
        {
            var myAge = stu?.Age ?? 0;//判断stu是否为空，不为空获取Age
            return myAge;
        }

        public static string NewFeature5()
        {
            Dictionary<string, string> myDic = new Dictionary<string, string>()
            {
                ["name"] = "Tate",
                ["gender"] = "男"
            };

            return myDic["name"];
        }
    }
}