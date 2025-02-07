using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FsCheck;

namespace ExaminationSystem
{
    public abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int NumOfQuestion { get; set; }
        public List<Question> ?Questions { get; set; }

       



        public abstract void ShowExam();


    }
}
