using System;
namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {  
            GradeBook book = new GradeBook();
           

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
           
  
           GradeStatistics statistics = book.ComputeStatistics();
           WriteResult("Average :", statistics.averageGrade);
           WriteResult("Highest :", (int)statistics.highestGrade);
           WriteResult("Lowest  :", (int)statistics.lowestGrade);
           WriteResult("Grade", statistics.LetterGrade);
            Console.WriteLine(book.Name);
            Console.ReadKey();  
        }

        private static void WriteResult(string description, string letterGrade)
        {
            Console.WriteLine($"{description} :{letterGrade}", description, letterGrade);
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + " " + result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + " " + result);
            Console.WriteLine("{0} : {1}",description,result);
        }
    }
}
