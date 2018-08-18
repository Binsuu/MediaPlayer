using Quiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.ModelView.GradeFive
{
   public static class GradeFive
    {
        private static List<Subjects> Subjects = new List<Subjects>();

        public static List<Animation> animations { get; set; }


        public static List<Subjects> GetSubjects()
        {
            Subjects = new List<Subjects>();
             Subjects.Add(new Subjects { Id="1",subject = "Maths", units = getMathsUnits() });
             Subjects.Add(new Subjects {Id="2", subject = "Science", units = getScienceUnits() });
            Subjects.Add(new Subjects { Id = "3", subject = "Social", units = getSocialUnits() });
            return Subjects;

        }
        private static List<Units> units = new List<Units>();

        private static List<Units> getSocialUnits()
        {
            List<Topics> topics = new List<Topics>();
            units = new List<Units>();
            topics.Add(new Topics("1", "i. Occupation Of My Neighbours", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            units.Add(new Units("1. Occupation Of My Neighbours") { Title = "Occupation Of My Neighbours", ListItems = topics });


            topics = new List<Topics>();
            topics.Add(new Topics("2", "i. Social Responsibility", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("3", "ii. Good Behaviour", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("4", "iii. People Become Great By Heart", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("5", "iv. Feel The Pain Of Others", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            units.Add(new Units("2. Me and My Family") { Title = "2. Me and My Family", ListItems = topics });

            topics = new List<Topics>();
            topics.Add(new Topics("6", "i. Our Traditions, Social Values And Norms", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("7", "ii. Our Glorious Traditions", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("8", "iii. Unity In Diversity", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("9", "iv. Festivals Of Our Country", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("10", "v. Our Nation Our Pride", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("11", "vi. Good People Of My District", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            units.Add(new Units("3. Our traditions, Social Values, Norms") { Title = "3. Our traditions, Social Values, Norms", ListItems = topics });

            topics = new List<Topics>();
            topics.Add(new Topics("12", "i. Quit Bad Habits", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("13", "ii. Anti-Social Activities", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("14", "iii. Unnecessary Imitation", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("15", "iv. Helpful Social Organisations", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("16", "v. Role Of Local Body", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("17", "vi. Forgiveness And Reconciliation", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            units.Add(new Units("4. Social Problems and Solutions") { Title = "4. Social Problems and Solutions", ListItems = topics });

            topics = new List<Topics>();
            topics.Add(new Topics("18", "i. Fundamental Rights", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("19", "ii. Our Fundamental Duties", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("20", "iii. Our National Heritage", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("21", "iv. Social Responsibility", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("22", "v. District Assembly And District Co-Ordination Committee", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("23", "vi. Equal Treatment", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            units.Add(new Units("5. Civil Awareness") { Title = "5. Civil Awareness", ListItems = topics });

            topics = new List<Topics>();
            topics.Add(new Topics("24", "i. Natural Region Of Nepal", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("25", "ii. Climate And Lifestyle Of Nepal", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("26", "iii. Natural Vegetation Of Nepal", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("27", "iv. Soils Of Our Country", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("28", "v. Drawing Map Of Nepal", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("29", "vi. Symbols Used In Maps", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("30", "vii. Uses Of Globe And Maps", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("31", "viii. Our Neighbouring Countries", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            units.Add(new Units("6. Our Earth") { Title = "6. Our Earth", ListItems = topics });

            topics = new List<Topics>();
            topics.Add(new Topics("32", "i. Historical Things Of Our Community", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("33", "ii. Ancient Nepal", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("34", "iii. Our National Heroes", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("35", "iv. Our Head Of State And Government", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            units.Add(new Units("7. Our Past") { Title = "7. Our Past", ListItems = topics });

            topics = new List<Topics>();
            topics.Add(new Topics("36", "i. Economic Activities Of My District", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("37", "ii. Learn To Take Care", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("38", "iii. Domestic Products", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("39", "iv. Use Of Domestic Products", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("40", "v. Economic Activities Of Our Country", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            units.Add(new Units("8. Our Economic Activities") { Title = "8. Our Economic Activities", ListItems = topics });

            topics = new List<Topics>();
            topics.Add(new Topics("41", "Creative Art", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            units.Add(new Units("9. Creative Art") { Title = "9. Creative Art", ListItems = topics });


            return units;
        }

        private static List<Units> getScienceUnits()
        {
            units = new List<Units>();
            List<Topics> topics = new List<Topics>();
            topics.Add(new Topics("1", "i. Invertebrates", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("2", "ii. Vertebrates", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("3", "iii. Parts of a Flowering Plants", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("4", "iv. Growing Plants", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("5", "v. Life Processes", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("6", "vi. Lifecycle of an Insect", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("7", "vii. Cell", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("8", "vii. Matter and Change of States", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("9", "ix. Energy", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("10", "x. Environmental Destruction", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("11", "xi. Conservation of Environment", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("12", "xii. Relation Between Animals and Plants", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("13", "xiii. Weather", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("14", "xiv. Cloud", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("15", "xv. The Sun and the Solar System", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("16", "xvii. The Earth", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("17", "xviii. Internal Structure of the Earth", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("18", "xix. Types of Information Sources", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("19", "xx. Types of Communication", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("20", "xxi. Simple Technologies", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("21", "xxii. Personal Hygiene", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("22", "xxiii. Environmental Cleanliness", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("23", "xxiv. Solid Waste", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("24", "xxv. Malnutrition and its Effect", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("25", "xxvi. Diseases", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("26", "xxvii. Safety and First Aid", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("27", "xxvii. Health Service", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("28", "xxviii. Smoking, Alcohol and Drugs", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("29", "xxix. Locomotor Skills", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("30", "xxix. Ball Games", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("31", "xxx. Non-Locomotor Skills", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("32", "xxxi. Creative Games", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("33", "xxxii. PT and Drill", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("34", "xxxiii. Minor or Local Games", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("35", "xxiv. Gymnastics and Balancing", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            units.Add(new Units("1. Chapters") { Title = "1. Chapters", ListItems = topics });


          


            return units;
        }


        private static List<Units> getMathsUnits()
        {
            units = new List<Units>();
            List<Topics> topics = new List<Topics>();

            topics.Add(new Topics("1","i. Number System", false, false, false, false, false, false, false, false, false, false, false) { animations= GetAnimations() });
            topics.Add(new Topics("2", "ii. Properties of Whole Number", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("3", "iii. Four Fundamental Operations", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("4", "iv. Fraction", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("5", "v. Decimal", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("6", "vi. Percent", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("7", "vii. Profit & Loss", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("8", "viii. Algebra", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("9", "ix. Algebraic Expressions", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("10", "x. Set", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("11", "xi. Unitary Method", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("12", "xii. Ratio", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("13", "xiii. Time & Money", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("14", "ix. The Metric Measurement System", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("15", "x. Perimeter, Area & Volume", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("16", "xi. Geometry", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("17", "xii. Triangles & Quadrilateral", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("18", "xiii. Statistics", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
            topics.Add(new Topics("19", "xiv. Ordered pairs & Coordinates", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });

            units.Add(new Units("1. Chapters") { Title = "1. Chapters", ListItems = topics });


            return units;
        }

        public static List<Animation> GetAnimations()
        {
            animations = new List<Animation>();
            animations.Add(new Animation { Sno = 1, Description = "i. Invertebrates" });
            animations.Add(new Animation { Sno = 2, Description = "ii. Vertebrates" });
            animations.Add(new Animation { Sno = 3, Description = "iii. Parts of a Flowering Plants" });
            animations.Add(new Animation { Sno = 4, Description = "iv. Life Processes" });
            animations.Add(new Animation { Sno = 5, Description = "v. Lifecycle of an Insect" });
            return animations;
        }
        //public static List<Units> getUnits()
        //{
        //    List<Topics> topics = new List<Topics>();
        //    topics.Add(new Topics("1", "i. Occupation Of My Neighbours", false,false,false,false,false,false,false,false,false,false,false) { animations=  GetAnimations() });
        //    units.Add(new Units("1. Occupation Of My Neighbours") { Title = "Occupation Of My Neighbours", ListItems = topics });


        //    topics = new List<Topics>();
        //    topics.Add(new Topics("1", "i. Social Responsibility", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("2", "ii. Good Behaviour", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("3", "iii. People Become Great By Heart", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("4", "iv. Feel The Pain Of Others", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    units.Add(new Units("2. Me and My Family") { Title = "2. Me and My Family", ListItems = topics });

        //    topics = new List<Topics>();
        //    topics.Add(new Topics("5", "i. Our Traditions, Social Values And Norms", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("6", "ii. Our Glorious Traditions", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("iii. Unity In Diversity", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("iv. Festivals Of Our Country", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("v. Our Nation Our Pride", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("vi. Good People Of My District", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    units.Add(new Units("3. Our traditions, Social Values, Norms") { Title = "3. Our traditions, Social Values, Norms", ListItems = topics });

        //    topics = new List<Topics>();
        //    topics.Add(new Topics("i. Quit Bad Habits", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("ii. Anti-Social Activities", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("iii. Unnecessary Imitation", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("iv. Helpful Social Organisations", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("v. Role Of Local Body", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("vi. Forgiveness And Reconciliation", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    units.Add(new Units("4. Social Problems and Solutions") { Title = "4. Social Problems and Solutions", ListItems = topics });

        //    topics = new List<Topics>();
        //    topics.Add(new Topics("i. Fundamental Rights", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("ii. Our Fundamental Duties", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("iii. Our National Heritage", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("iv. Social Responsibility", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("v. District Assembly And District Co-Ordination Committee", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("vi. Equal Treatment", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    units.Add(new Units("5. Civil Awareness") { Title = "5. Civil Awareness", ListItems = topics });

        //    topics = new List<Topics>();
        //    topics.Add(new Topics("i. Natural Region Of Nepal", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("ii. Climate And Lifestyle Of Nepal", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("iii. Natural Vegetation Of Nepal", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("iv. Soils Of Our Country", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("v. Drawing Map Of Nepal", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("vi. Symbols Used In Maps", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("vii. Uses Of Globe And Maps", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("viii. Our Neighbouring Countries", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    units.Add(new Units("6. Our Earth") { Title = "6. Our Earth", ListItems = topics });

        //    topics = new List<Topics>();
        //    topics.Add(new Topics("i. Historical Things Of Our Community", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("ii. Ancient Nepal", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("iii. Our National Heroes", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("iv. Our Head Of State And Government", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    units.Add(new Units("7. Our Past") { Title = "7. Our Past", ListItems = topics });

        //    topics = new List<Topics>();
        //    topics.Add(new Topics("i. Economic Activities Of My District", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("ii. Learn To Take Care", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("iii. Domestic Products", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("iv. Use Of Domestic Products", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    topics.Add(new Topics("v. Economic Activities Of Our Country", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    units.Add(new Units("8. Our Economic Activities") { Title = "8. Our Economic Activities", ListItems = topics });

        //    topics = new List<Topics>();
        //    topics.Add(new Topics("Creative Art", false, false, false, false, false, false, false, false, false, false, false) { animations=  GetAnimations() });
        //    units.Add(new Units("9. Creative Art") { Title = "9. Creative Art", ListItems = topics });


        //    return units;
        //}
    }
}
