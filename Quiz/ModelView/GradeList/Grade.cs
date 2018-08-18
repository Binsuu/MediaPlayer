using Quiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.ModelView.GradeList
{
    static class Grade
    {
        public static List<Grades> GetGrade()
        {
            
            List<Grades> grades = new List<Grades>();
            grades.Add(new Grades { Id = "1", grade = "Grade One", subjects = GradeFive.GradeFive.GetSubjects() });
            grades.Add(new Grades { Id = "2", grade = "Grade Two", subjects = GradeFive.GradeFive.GetSubjects() });
            grades.Add(new Grades { Id = "3", grade = "Grade Three", subjects = GradeFive.GradeFive.GetSubjects() });

            grades.Add(new Grades { Id = "4", grade = "Grade Four", subjects = GradeFive.GradeFive.GetSubjects() });
            grades.Add(new Grades { Id = "5", grade = "Grade Five", subjects = GradeFive.GradeFive.GetSubjects() });
            grades.Add(new Grades { Id = "6", grade = "Grade Six", subjects = GradeFive.GradeFive.GetSubjects() });

            grades.Add(new Grades { Id = "7", grade = "Grade Seven", subjects = GradeFive.GradeFive.GetSubjects() });
            grades.Add(new Grades { Id = "8", grade = "Grade Eight", subjects = GradeFive.GradeFive.GetSubjects() });


            grades.Add( new Grades { Id="9",grade="Grade Nine",subjects= GradeFive.GradeFive.GetSubjects() });
            grades.Add(new Grades { Id="10",grade = "Grade Ten", subjects = GradeFive.GradeFive.GetSubjects() });
            return grades;
        }
    }
}
