using Quiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.ModelView.GradeFive
{
  public static class GradeFiveMCQ
    {

        private static List<Answer>  answers = new List<Answer>();
        private static List<Question> questions = new List<Question>();
        private static List<Subjects> Subjects = new List<Subjects>();

        public static List<Subjects> GetQuestion()
        {
            Subjects = new List<Subjects>();
            Subjects.Add(new Subjects { subject = "Science", questions=GetScienceQuestion() });
            return Subjects;

        }

        //public static List<Question> GetQuestions()
        //{
        //    questions = new List<Question>();
        //}

        private static List<Question> GetScienceQuestion()
        {
            questions = new List<Question>();
            answers= new List<Answer>();
            answers.Add(new Answer { Id = 1, Option1 = new Options { option="(a) an oxidising agent", isCorrect = true },
                                           Option2 = new Options { option= "(b) a reducing agent", isCorrect = false },
                                           Option3 = new Options { option = "(c) a dehydrating agent", isCorrect = false },
                                            Option4 = new Options {  option = "(d) a catalyst", isCorrect = false },
                                            Qno = 1 });
            questions.Add(new Question { classCode = 5, SubjectCode = 1, ChapterCode = 1, Qno = 1, Qst = "When the gases sulphur dioxide and hydrogen sulphide mix in the presence of water, the reaction SO2 + 2H2S → 2H2O + 3S occurs. Here, hydrogen sulphide is acting as", answers = answers });
           
            answers = new List<Answer>();   
            questions.Add(new Question { });
            answers.Add(new Answer { Id = 1, Option1= new Options { option = "(a) zinc is costlier than tin.", isCorrect = true },
                                            Option2 = new Options{ option = "(b) zinc has a higher melting point than tin.", isCorrect = false },
                Option3 = new Options { option = "(c) zinc is more reactive than tin.", isCorrect = false },
                Option4 = new Options { option = "(d) zinc is less reactive than tin.", isCorrect = false },
                Qno = 2 });
            questions.Add(new Question { classCode = 5, SubjectCode = 1, ChapterCode = 1, Qno = 2, Qst = "2. Food cans are coated with tin and not zinc because : ", answers = answers });
           
            answers = new List<Answer>();
            questions.Add(new Question { });
            answers.Add(new Answer
            {
                Id = 1,
                Option1 = new Options { option = "(a) zinc is costlier than tin.", isCorrect = true },
                Option2 = new Options { option = "(b) zinc has a higher melting point than tin.", isCorrect = false },
                Option3 = new Options { option = "(c) zinc is more reactive than tin.", isCorrect = false },
                Option4 = new Options { option = "(d) zinc is less reactive than tin.", isCorrect = false },
                Qno = 3
            });

            questions.Add(new Question { classCode = 5, SubjectCode = 1, ChapterCode = 1, Qno = 3, Qst = " 3. Aluminium is used in thermite welding be­cause", answers = answers });

            answers = new List<Answer>();
            questions.Add(new Question { });
            answers.Add(new Answer {
                Id = 1,
                Option1 =new Options { option = "(a) Grass, Wheat and Mango", isCorrect = true },
                Option2 = new Options { option = "(b) Grass, Goat and Human", isCorrect = false },
                Option3 = new Options { option = "(c) Goat, Cow and Elephant", isCorrect = false },
                Option4 = new Options { option = "(d) Grass, Fish and Goat", isCorrect = false },
                Qno = 4 });
            questions.Add(new Question { classCode = 5, SubjectCode = 1, ChapterCode = 1, Qno = 4, Qst = " 4. Which of the following constitutes a food chain?", answers = answers });

            answers = new List<Answer>();
            questions.Add(new Question { });
            answers.Add(new Answer
            {
                Id = 1,
                Option1 = new Options { option = "(a) Grass, Wheat and Mango", isCorrect = true },
                Option2 = new Options { option = "(b) Grass, Goat and Human", isCorrect = false },
                Option3 = new Options { option = "(c) Goat, Cow and Elephant", isCorrect = false },
                Option4 = new Options { option = "(d) Grass, Fish and Goat", isCorrect = false },
                Qno = 5
            });
            questions.Add(new Question { classCode = 5, SubjectCode = 1, ChapterCode = 1, Qno = 5, Qst = " 5. In the following equations Na2CO3 + xHCl → 2NaCl + CO2 + H2O the value of x is", answers = answers });

            answers = new List<Answer>();
            questions.Add(new Question { });
            answers.Add(new Answer
            {
                Id = 1,
                Option1 = new Options { option = "(a) Grass, Wheat and Mango", isCorrect = true },
                Option2 = new Options { option = "(b) Grass, Goat and Human", isCorrect = false },
                Option3 = new Options { option = "(c) Goat, Cow and Elephant", isCorrect = false },
                Option4 = new Options { option = "(d) Grass, Fish and Goat", isCorrect = false },
                Qno = 6
            });
            questions.Add(new Question { classCode = 5, SubjectCode = 1, ChapterCode = 1, Qno = 6, Qst = " 6. The anther contains:", answers = answers });

            answers = new List<Answer>();
            questions.Add(new Question { });
            answers.Add(new Answer
            {
                Id = 1,
                Option1 = new Options { option = "(a) Grass, Wheat and Mango", isCorrect = true },
                Option2 = new Options { option = "(b) Grass, Goat and Human", isCorrect = false },
                Option3 = new Options { option = "(c) Goat, Cow and Elephant", isCorrect = false },
                Option4 = new Options { option = "(d) Grass, Fish and Goat", isCorrect = false },
                Qno = 7
            });
            questions.Add(new Question { classCode = 5, SubjectCode = 1, ChapterCode = 1, Qno = 7, Qst = " 7. The oceans cover almost______ percent of the surface of earth with water and act as a vast collector of______energy.", answers = answers });

            answers = new List<Answer>();
            questions.Add(new Question { });
            answers.Add(new Answer
            {
                Id = 1,
                Option1 = new Options { option = "(a) Grass, Wheat and Mango", isCorrect = true },
                Option2 = new Options { option = "(b) Grass, Goat and Human", isCorrect = false },
                Option3 = new Options { option = "(c) Goat, Cow and Elephant", isCorrect = false },
                Option4 = new Options { option = "(d) Grass, Fish and Goat", isCorrect = false },
                Qno = 8
            });
            questions.Add(new Question { classCode = 5, SubjectCode = 1, ChapterCode = 1, Qno = 8, Qst = " 8. The split rings in motion are called", answers = answers });

            answers = new List<Answer>();
            questions.Add(new Question { });
            answers.Add(new Answer
            {
                Id = 1,
                Option1 = new Options { option = "(a) Grass, Wheat and Mango", isCorrect = true },
                Option2 = new Options { option = "(b) Grass, Goat and Human", isCorrect = false },
                Option3 = new Options { option = "(c) Goat, Cow and Elephant", isCorrect = false },
                Option4 = new Options { option = "(d) Grass, Fish and Goat", isCorrect = false },
                Qno = 9
            });
            questions.Add(new Question { classCode = 5, SubjectCode = 1, ChapterCode = 1, Qno = 9, Qst = "9. Magnetic lines of force", answers = answers });

            answers = new List<Answer>();
            questions.Add(new Question { });
            answers.Add(new Answer
            {
                Id = 1,
                Option1 = new Options { option = "(a) Grass, Wheat and Mango", isCorrect = true },
                Option2 = new Options { option = "(b) Grass, Goat and Human", isCorrect = false },
                Option3 = new Options { option = "(c) Goat, Cow and Elephant", isCorrect = false },
                Option4 = new Options { option = "(d) Grass, Fish and Goat", isCorrect = false },
                Qno = 10
            });
            questions.Add(new Question { classCode = 5, SubjectCode = 1, ChapterCode = 1, Qno = 10, Qst = "10. Which of the following hydroxides is most basic?", answers = answers });



            return questions;
        }
        }
}
