using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_ableDotNet.Statistics
{
    class Subject
    {
        public string NameSubject { get; }
        public float Mark { get; }

        public Subject(string nameSubject, float mark)
        {
            NameSubject = nameSubject;
            if (mark < 100 && mark > 0)
            {
                Mark = mark;
            }
            else
            {
                throw new ArgumentException("Mark cannot be more 100 or less then 0");
            }
        }

        public override string ToString()
        {
            return $"{NameSubject}: {Mark}";
        }
    }
}
