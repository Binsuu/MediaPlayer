using Quiz.Model;
using Quiz.ModelView.GradeFive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.ModelView
{
  public static  class QuestionCollection
    {
        public static List<Grades> GetQuestions()
        {

            List<Grades> grades = new List<Grades>();
            grades.Add(new Grades { grade = "Five", subjects = GradeFiveMCQ.GetQuestion() });
            return grades;
        }
    }
}
