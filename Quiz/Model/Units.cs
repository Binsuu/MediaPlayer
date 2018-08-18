using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Model
{

    public class Grades
    {
        public string Id { get; set; }
        public string grade { get; set; }
        public List<Subjects> subjects { get; set; }
        public Grades()
        {
            subjects = new List<Subjects>();
        }
    }

    public class Subjects
    {
        public string Id { get; set; }
        public string subject { get; set; }
        public List<Units> units { get; set; }
        public List<Question> questions { get; set; }
        public Subjects()
        {
            units = new List<Units>();
            questions = new List<Question>();
        }


    }

    public class Units
    {
        public Units(string title)
        {
            Title = title;
         
        }
      
        public string Title { get; set; }
        public List<Topics> ListItems { get; set; } = new List<Topics>();

        public void AddListItem(Topics listItem)
        {
            ListItems.Add(listItem);
        }
    }


    public class Topics
    {
        public Topics(string id,string name,  bool synopsis = false, bool web = false, bool link = false, bool graphic = false, bool quiz = false, bool worksheet = false, bool animiation = false, bool mcq = false, bool rla = false, bool teaching_idea = false, bool topic = false)
        {
            Name = name;
            Id = id;
            Animiation = Animiation;
            MCQ = mcq;
            RLA = rla;
            Teaching = teaching_idea;
            Topic = synopsis;
            Synopsis = synopsis;
            Web = web;
            Links = link;
            Graphic = graphic;
            Quiz = quiz;
            Worksheet = worksheet;
            animations = new List<Animation>();
        }
        public Topics()
        {
            animations = new List<Animation>();
        }
        public List<Animation> animations { get; set; }
        public string Id { get; set; }
        public bool Animiation { get; set; }
        public bool MCQ { get; set; }
        public bool RLA { get; set; }
        public bool Teaching { get; set; }
        public bool Idea { get; set; }
        public bool Topic { get; set; }
        public bool Synopsis { get; set; }
        public bool Web { get; set; }
        public bool Links { get; set; }
        public bool Graphic { get; set; }
        public bool Quiz { get; set; }
        public bool Worksheet { get; set; }
        public string Name { get; set; }
      
    }

    public class Question
    {
        public int classCode { get; set; }
        public int SubjectCode { get; set; }
        public int ChapterCode { get; set; }
        public int Qno { get; set; }
        public string Qst { get; set; }
      public List<Answer> answers { get; set; }
    }

    public class Answer
    {
        
        public int Id { get; set; }
        public int Qno { get; set; }
        public Options Option1 { get; set; }
        public Options Option2 { get; set; }
        public Options Option3 { get; set; }
        public Options Option4 { get; set; }
    }
    public class Options {
        public string option { get; set; }
        public bool isCorrect { get; set; }
    }
    public class Animation {
        public int Sno { get; set; }
        public string Description { get; set; }
    }


}



