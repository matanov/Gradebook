using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    
    {
        static void Main(string[] args)
        {
        var values =  new List<double>() {10.1, 20.2,23.6,16.4, 23.6};
        var result =0.0;
        foreach (var value in values)
        {
            result += value;
        }
        result /= values.Count;
        
        Console.WriteLine($"The average is {result:N2}");
        
        
        if (args.Length > 0)
        {
            Console.WriteLine($"Hello World! Panto is Here today {args[0]}");
        }

        else
        {
            Console.WriteLine("No user input");
        }

        }
        
        
    }
}
