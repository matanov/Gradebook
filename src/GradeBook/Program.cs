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
        book.ShowStatistics();

    //    var grades =  new List<double>() {12.7, 10.3,6.11,4.1};
    //    grades.Add(56.1);
    //    var result =0.0;
    //    var highGrade = double.MinValue;
    //    var lowestGrade = double.MaxValue;
    //    foreach (var number in grades)
    //    {
    //        highGrade = Math.Max(number, highGrade);
    //        lowestGrade = Math.Min(number, lowestGrade);
    //        result += number;
    //    }
    //    result /= grades.Count;
        
    //     Console.WriteLine($"The lowest grade is {lowestGrade}");
    //     Console.WriteLine($"The highest grade is {highGrade}");
        
    //     Console.WriteLine($"The average is {result:N2}");

        }

    }
   
}