using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0){
            Console.WriteLine($"Hello World! Panto is Here today {args[0]}");
            }

            else{
                Console.WriteLine("No user input");
            }
        }
        
    }
}
