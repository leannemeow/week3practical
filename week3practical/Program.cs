using System;
using week3practical;


class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        Student student2 = new Student("John Doe", 18);

        Console.WriteLine("2024 students");
        student1.Display();
        Console.WriteLine();
        student2.Display();
        Console.WriteLine();

        student1.GetOlder();
        student2.GetOlder();

        Console.WriteLine("2025 students");
        student1.Display();
        Console.WriteLine();
        student2.Display();
        Console.WriteLine();
    }

}

    

