using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    
    {
        static void Main(string[] args)
        {

            var book = new DiskBook ("Scott's grade book");
            book.GradeAdded += OnGradeAdded;


            // book.AddGrade(89.1);
            // book.AddGrade(90.5);
            // book.AddGrade(77.5);
            // book.GetStatistics();

            //var done = false;
            EnterGrades(book);

            var stats = book.GetStatistics();

            System.Console.WriteLine($"The name of the book is{book.Name}");
            System.Console.WriteLine($"Average grade is {stats.Average:N1}");
            System.Console.WriteLine($"Highest garde is {stats.High}");
            System.Console.WriteLine($"Lowest grade is {stats.Low}");
            System.Console.WriteLine($"The letter is {stats.Letter} ");



        }

        private static void EnterGrades(IBook book)
        {
            
            while (true)
            {
                Console.WriteLine("Enter a grade or Q to quit:");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }



            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            System.Console.WriteLine("A grade was added!");
        }

    }
   
}