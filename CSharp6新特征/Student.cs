using System;

namespace CSharp6新特征
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; } = "用户姓名";
        public DateTime Birthday { get; set; } = Convert.ToDateTime("2021-01-08");

        //public int Age => DateTime.Now.Year - Birthday.Year;
        public int Age { get; set; }
    }
}