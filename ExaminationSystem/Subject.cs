using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Subject
    {
       

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam exam { get; set; }

        public void CreateExam(string ExamType)
        {

            Console.WriteLine("Enter the Time of Exam:");
            int time=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number Of Questions:");
            int Num = int.Parse(Console.ReadLine());
            exam= ExamType=="Practical"?new PracticalExam():new FinalExam();
            exam.TimeOfExam = time;
            exam.NumOfQuestion = Num;
            exam.Questions = new List<Question>();
            for (int i = 0; i < Num; i++) 
            {
                Console.WriteLine("Enter The Body Of the Question:");
                string Body=Console.ReadLine();
                Console.WriteLine("Please Enter The Grade Of the Question");
                int Grade=int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter The Type Of the Question:(1 For True Or False) (2 For Mcq )");
                int TypeOf = int.Parse(Console.ReadLine());
                if (TypeOf == 1)
                {
                    Console.WriteLine("Enter The Correct Answer (1 For True )(2 For False ):");
                    int Right = int.Parse(Console.ReadLine());
                    exam.Questions.Add(new TrueFalseQ(Body, Right, Grade));
                }
                else if (TypeOf == 2) 
                {
                    Console.WriteLine("Enter The Right Answer From 1-3");
                    int Right=int.Parse(Console.ReadLine());    
                    List<Answers>ans=new List<Answers>();
                    for (int j = 0;j < 3; j++) 
                    {
                        Console.WriteLine($"Please Enter The Answers{j + 1}:");
                        string AnswersOfTheQ=Console.ReadLine();
                        ans.Add(new Answers (j+1, AnswersOfTheQ));
                    }exam.Questions.Add(new MCQ (Body,ans,Right,Grade));
                }
            }
        }
    }
}
