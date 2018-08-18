using Quiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.ModelView.GradeFour
{
    
    public static  class Animiation
    {
        public static List<Subjects> subjects { get; set; }
        public static List<Units> units { get; set; }
        public static List<Topics> topics { get; set; }
        public static List<Animation> animations { get; set; }

        public static List<Subjects> GetAnimiation()
    {
            subjects = new List<Subjects>();
            subjects.Add(new Subjects {Id="2", subject = "Science", units = GetScienceAnimiation() });
            subjects.Add(new Subjects { Id="1",subject = "Science", units = GetMathsAnimiation() });
            subjects.Add(new Subjects { Id="3",subject = "Science", units = GetSocialAnimiation() });
            return subjects;
    }

        private static List<Units> GetSocialAnimiation()
        {
            units.Add(new Units("9. Creative Art") { Title = "9. Creative Art", ListItems = GetSocialTopics() });
            return units;
        }

        private static List<Topics> GetSocialTopics()
        {

            animations.Add(new Animation { Sno = 1, Description = "i. Invertebrates" });
            animations.Add(new Animation { Sno = 2, Description = "ii. Vertebrates" });
            animations.Add(new Animation { Sno = 3, Description = "iii. Parts of a Flowering Plants" });
            animations.Add(new Animation { Sno = 4, Description = "iv. Life Processes" });
            animations.Add(new Animation { Sno = 5, Description = "v. Lifecycle of an Insect" });

            topics.Add(new Topics { Id="1",animations=animations});
            animations.Add(new Animation { Sno = 1, Description = "i. Invertebrates" });
            animations.Add(new Animation { Sno = 2, Description = "ii. Vertebrates" });
            animations.Add(new Animation { Sno = 3, Description = "iii. Parts of a Flowering Plants" });
            animations.Add(new Animation { Sno = 4, Description = "iv. Life Processes" });
            animations.Add(new Animation { Sno = 5, Description = "v. Lifecycle of an Insect" });
            topics.Add(new Topics { Id = "2", animations = animations });

            animations.Add(new Animation { Sno = 1, Description = "i. Invertebrates" });
            animations.Add(new Animation { Sno = 2, Description = "ii. Vertebrates" });
            animations.Add(new Animation { Sno = 3, Description = "iii. Parts of a Flowering Plants" });
            animations.Add(new Animation { Sno = 4, Description = "iv. Life Processes" });
            animations.Add(new Animation { Sno = 5, Description = "v. Lifecycle of an Insect" });
            topics.Add(new Topics { Id = "3", animations = animations });

            animations.Add(new Animation { Sno = 1, Description = "i. Invertebrates" });
            animations.Add(new Animation { Sno = 2, Description = "ii. Vertebrates" });
            animations.Add(new Animation { Sno = 3, Description = "iii. Parts of a Flowering Plants" });
            animations.Add(new Animation { Sno = 4, Description = "iv. Life Processes" });
            animations.Add(new Animation { Sno = 5, Description = "v. Lifecycle of an Insect" });

            topics.Add(new Topics { Id = "4", animations = animations });
            animations.Add(new Animation { Sno = 1, Description = "i. Invertebrates" });
            animations.Add(new Animation { Sno = 2, Description = "ii. Vertebrates" });
            animations.Add(new Animation { Sno = 3, Description = "iii. Parts of a Flowering Plants" });
            animations.Add(new Animation { Sno = 4, Description = "iv. Life Processes" });
            animations.Add(new Animation { Sno = 5, Description = "v. Lifecycle of an Insect" });


            return topics;
        }


        private static List<Units> GetMathsAnimiation()
        {
            units.Add(new Units("1. Chapters") { Title = "1. Chapters", ListItems = GetSocialTopics() });
            return units;
        }

        private static List<Units> GetScienceAnimiation()
        {
            units.Add(new Units("1. Chapters") { Title = "1. Chapters", ListItems = GetSocialTopics() });
            return units;
        }
    }
}
