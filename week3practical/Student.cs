

using System;
using System.Runtime.InteropServices;

namespace week3practical
{
    public class Student
    {
        private int stuId;
        private string name;
        private int age;
        private static int stuCount = 0;

        public int StuId
        {
            get { return stuId; }
            private set { stuId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static int StuCount
        {
            get { return stuCount; }
            private set { stuCount = value; }
        }

        public Student()
        {
            name = "Jane Doe";
            age = 16;
            stuId = stuCount++;
        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            StuId = stuCount++;
        }

        public void Display()
        {
            Console.WriteLine($"Student ID: {stuId}");
            Console.WriteLine($"Student name: {name}");
            Console.WriteLine($"Student age: {age}");
        }

        public int GetOlder()
        {
            return age++;
        }


    }
}
