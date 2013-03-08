using System;
using System.Linq;

namespace SchoolDemo
{
    public class Discipline : IComment
    {
        public String DisciplineName { get; set; }
        public String Note { get; set; }
        public int LectureNumber { get; set; }
        public int ExcercisesNumber { get; set; }

        public Discipline()
        {
            DisciplineName = null;
            LectureNumber = 0;
            ExcercisesNumber = 0;
        }

        public Discipline(string discipline, int lectures, int excercises)
        {
            if (String.IsNullOrWhiteSpace(discipline)) throw new ArgumentNullException("The give argument is null or have only white spaces");
            else if (lectures <= 0 || excercises <= 0) throw new ArgumentException("Zero or negative exception");
            else
            {
                DisciplineName = discipline;
                LectureNumber = lectures;
                ExcercisesNumber = excercises;
            }
        }

        public override string ToString()
        {
            return String.Format("Discipline name - {0}\nLecture number - {1}\nExcercises number - {2}", DisciplineName, LectureNumber, ExcercisesNumber);
        }
    }
}
