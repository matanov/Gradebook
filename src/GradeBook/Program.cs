using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    
    {
        static void Main(string[] args)
        {

        var book = new Book("Scott's grae book");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.5);
        book.GetStatistics();

        var stats = book.GetStatistics();

        System.Console.WriteLine($"Average grade is {stats.Average:N1}");
        System.Console.WriteLine($"Highest garde is {stats.High}");
        System.Console.WriteLine($"Lowest grade is {stats.Low}");



        }

    }
   
}