using System;

namespace N_ableDotNet.Statistics
{
    public class StudentStatistic : IStatistics
    {
        public double GetAverageGrade(Student student)
        {
            if (student.Subjects.Count == 0)
            {
                throw new ArgumentException("Subjects cannot be empty");
            }

            float averageGrade = 0;

            foreach (var item in student.Subjects)
            {
                averageGrade += item.Mark;
            }

            return averageGrade / student.Subjects.Count;
        }

        public Subject GetHighestGrade(Student student)
        {
            if (student.Subjects.Count == 0)
            {
                throw new ArgumentException("Subjects cannot be empty");
            }

            float max = 0;
            int index = 0;

            for (int i = 0; i < student.Subjects.Count; ++i)
            {
                if (student.Subjects[i].Mark >= max)
                {
                    max = student.Subjects[i].Mark;
                    index = i;
                }
            }

            return student.Subjects[index];
        }

        public Subject GetLowestGrade(Student student)
        {
            if (student.Subjects.Count == 0)
            {
                throw new ArgumentException("Subjects cannot be empty");
            }

            float max = student.Subjects[0].Mark;
            int index = 0;

            for (int i = 1; i < student.Subjects.Count; ++i)
            {
                if (student.Subjects[i].Mark < max)
                {
                    max = student.Subjects[i].Mark;
                    index = i;
                }
            }

            return student.Subjects[index];
        }
    }
}
