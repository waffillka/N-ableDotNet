using System;
using System.Collections.Generic;

namespace N_ableDotNet.Statistics
{
    public class Student
    {
        public string FirstName { get; }
        public string LastName { get; }

        public List<Subject> Subjects { get; }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Subjects = new List<Subject>();
        }

        public void AddSubject(Subject item)
        {
            Subjects.Add(item);
        }

        public void AddSubject(string nameSubject, ushort mark)
        {
            Subjects.Add(new Subject(nameSubject, mark));
        }
    }
}
