using System;
using System.Linq;

namespace N_ableDotNet.Statistics
{
    public class StudentStatisticLINQ : IStatistics
    {
        public double GetAverageGrade(Student student)
        {
            return student.Subjects.Count == 0 ? -1 : student.Subjects.Average(x => x.Mark);
        }

        public Subject? GetHighestGrade(Student student)
        {
            if (student.Subjects.Count == 0)
            {
                throw new ArgumentNullException("Subject's collection is empty");
            }

            var maxMark = student.Subjects.Max(x => x.Mark);
            return student.Subjects.Where(x => x.Mark == maxMark).FirstOrDefault();
        }

        public Subject? GetLowestGrade(Student student)
        {
            if (student.Subjects.Count == 0)
            {
                throw new ArgumentNullException("Subject's collection is empty");
            }

            var minMark = student.Subjects.Min(x => x.Mark);
            return student.Subjects.Where(x => x.Mark == minMark).FirstOrDefault();
        }
    }
}
