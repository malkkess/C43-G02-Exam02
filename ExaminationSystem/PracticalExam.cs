using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class PracticalExam : Exam
    {

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam");
            Console.WriteLine();
            
            foreach(var q in Questions)
            {
               
                q.showQ();
               
                Console.WriteLine("Enter Your Answer:");
                
                int UserAns =int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Exam Finished , Answers For Each Question:");
            Console.WriteLine("-----------------------------------------------------");
           
            foreach (var q in Questions)
            {
                Console.WriteLine($"{q.HeaderOfTheQ}:{q.BodyOfTheQ}");
                Console.WriteLine($"Correct Answer: {q.RightAnswers} - {q.Answers[q.RightAnswers - 1].AnswerText}");
            }


        }
    }
}
