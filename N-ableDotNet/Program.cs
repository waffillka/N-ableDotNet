using N_ableDotNet.Statistics;
using System;
using System.Collections.Generic;

namespace N_ableDotNet
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> mixNumbers = new List<int>()
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 66, 55, 44, 88, 77, 22, 33, 44, 55, 66, 85, 41, 52, 63, 96, 85};
            mixNumbers = (List<int>)Filters.OnlyEvenNumbers(mixNumbers);

            foreach (var item in mixNumbers)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            List<string> mixString = new List<string>()
                {"afsffs", "fhghdfgbc", "sdgdsg", "adgdgdsgd", "asd", "dsgds", "sad"};
            mixString = (List<string>)Filters.StringStartWithLetter(mixString);

            foreach (var item in mixString)
            {
                Console.Write(item + " ");
            }

            var student = new Student("George", "Sebik");
            var studentStat = new StudentStatisticLINQ();

            Console.WriteLine("\n" + studentStat.GetAverageGrade(student));


            student.AddSubject("ТМ", 70);
            student.AddSubject("РИК", 80);
            student.AddSubject("ПМУ", 90);
            student.AddSubject("ОБиП", 40);

            Console.WriteLine(studentStat.GetAverageGrade(student));
            Console.WriteLine(studentStat.GetHighestGrade(student));
            Console.WriteLine(studentStat.GetLowestGrade(student));
        }
    }
}
