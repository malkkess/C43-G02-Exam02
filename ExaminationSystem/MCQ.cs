using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class MCQ : Question
    {
        

        public MCQ( string bodyOfTheQ, List<Answers> ans, int rightanswers, int mark) : base("Please Choose One Answer", bodyOfTheQ, rightanswers, mark)
        {
            Answers = ans;
        }


        public override void showQ()
        {
            Console.WriteLine($"{HeaderOfTheQ}:\nThe Questions is : {BodyOfTheQ} Mark({Mark})");
            foreach (var answer in Answers)
            {
                Console.Write($"{answer.AnswerId}  -  {answer.AnswerText}");
                Console.Write("                        ");

            }
            Console.WriteLine();
        }
    }
}
