using System;
using System.IO;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            //Methods will go here
            AddGrades(book);
            SaveGrades(book);
            GetBookName(book);
            WriteResults(book);
            Console.ReadKey();
        }

        private static void WriteResults(GradeBook book)
        {
            GradeStatistics statistics = book.ComputeStatistics();
            WriteResult("Average :", statistics.averageGrade);
            WriteResult("Highest :", (int)statistics.highestGrade);
            WriteResult("Lowest  :", (int)statistics.lowestGrade);
            WriteResult(statistics.Description, statistics.LetterGrade);
            Console.WriteLine(book.Name);
        }

        private static void SaveGrades(GradeBook book)
        {
            using (StreamWriter outputfile = File.CreateText("grades.txt"))
            {
                book.WriteGrades(outputfile);

            }
        }

        private static void AddGrades(GradeBook book)
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
        }

        private static void GetBookName(GradeBook book)
        {
            try
            {
                Console.WriteLine("Please Enter name :");
                book.Name = Console.ReadLine();
            }


            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong");
            }
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
            Console.WriteLine("{0} : {1}", description, result);
        }
    }
}
