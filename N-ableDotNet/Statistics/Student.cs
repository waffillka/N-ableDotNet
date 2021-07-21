using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_ableDotNet.Statistics
{
    class Student
    {
        private string firstName;
        private string lastName;

        List<Subject> subjects;

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            subjects = new List<Subject>();
        }

        public void AddSubject(Subject item)
        {
            subjects.Add(item);
        }

        public void AddSubject(string nameSubject, ushort mark)
        {
            subjects.Add(new Subject(nameSubject, mark));
        }

        public string GetHighestGrade()
        {
            if (subjects.Count == 0)
            {
                throw new ArgumentException("Subjects cannot be empty");
            }

            float max = 0;
            int index = 0;

            for (int i = 0; i < subjects.Count; ++i)
            {
                if (subjects[i].Mark >= max)
                {
                    max = subjects[i].Mark;
                    index = i;
                }
            }

            return subjects[index].ToString();
        }

        public string GetLowestGrade()
        {
            if (subjects.Count == 0)
            {
                throw new ArgumentException("Subjects cannot be empty");
            }

            float max = subjects[0].Mark;
            int index = 0;

            for (int i = 1; i < subjects.Count; ++i)
            {
                if (subjects[i].Mark < max)
                {
                    max = subjects[i].Mark;
                    index = i;
                }
            }

            return subjects[index].ToString();
        }

        public string GetAverageGrade()
        {
            if (subjects.Count == 0)
            {
                throw new ArgumentException("Subjects cannot be empty");
            }

            float averageGrade = 0;

            foreach(var item in subjects)
            {
                averageGrade += item.Mark;
            }

            return $"Avarage grade is {averageGrade / subjects.Count}";
        }
    }
}
