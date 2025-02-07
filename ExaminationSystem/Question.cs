using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class Question
    {

        public string HeaderOfTheQ { get; set; }
        public string BodyOfTheQ { get; set; }
        public int Mark { get; set; }
        public List<Answers> Answers { get; set; } = new List<Answers>();
        public int RightAnswers { get; set; }

        public Question(string headerOfTheQ, string bodyOfTheQ, int rightanswers, int mark)
        {
            HeaderOfTheQ = headerOfTheQ;
            BodyOfTheQ = bodyOfTheQ;
            Mark = mark;
            RightAnswers = rightanswers;

        }
        public abstract void showQ();



    }
}
