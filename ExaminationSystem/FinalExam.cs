using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class FinalExam : Exam
    {
        public override void ShowExam()
        {
            Console.WriteLine("Final Exam");
            int Count = 0;
            int sum = 0;
            foreach (var q in Questions)
            {
                q.showQ();
                
                
                Console.WriteLine("Enter Your Answer:");
                int userAns = int.Parse(Console.ReadLine());

                if (userAns == q.RightAnswers)
                {
                    
                    Count += q.Mark;
                }
                sum += q.Mark;

            }
            Console.WriteLine("Exam Finished");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"Your Grade Is {Count} Out OF {sum}");
            Console.WriteLine("Correct Answers For Each Question is :");
            foreach (var q in Questions) 
            {
                Console.WriteLine($"{q.HeaderOfTheQ}:{q.BodyOfTheQ}");
                Console.WriteLine($"Correct Answer: {q.RightAnswers} - {q.Answers[q.RightAnswers - 1].AnswerText}");
            }

        }
    }
}
