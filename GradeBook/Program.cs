using System;
using System.Collections.Generic;
namespace GradeBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var book = new Book("Mybook");
            book.AddGrade(89.1);
            book.AddGrade(22.1);
            book.AddGrade(32.1);
            var result = book.GetStatistics();
            Console.WriteLine($"The highest grade is {result.High}");
            Console.WriteLine($"The lowest grade is {result.Low}");
            Console.WriteLine($"The average grade is {result.Average}");




        }
    }
}
