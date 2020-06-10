 using System;
 using System.Collections.Generic;
 
 namespace GradeBook
 {
 
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
            

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var average =0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var grade in grades){
                average += grade;
                highGrade = Math.Max(highGrade,grade);
                lowGrade = Math.Min(lowGrade,grade);
            }
            average /= grades.Count;
            System.Console.WriteLine($"Average grade is {average:N1}");
            System.Console.WriteLine($"Highest garde is {highGrade}");
            System.Console.WriteLine($"Lowest grade is {lowGrade}");

        }
        List<double> grades;
        private string name;
    }

 }                                  