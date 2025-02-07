using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class TrueFalseQ : Question
    {
        public TrueFalseQ( string bodyOfTheQ,  int rightanswers, int mark) : base("True Or False Question", bodyOfTheQ, rightanswers, mark)
        {
            Answers = new List<Answers>
        {
            new Answers ( 1,  "True" ),
            new Answers  (2,"False" )
        };
        }

        public override void showQ()
        {
            Console.WriteLine($"{HeaderOfTheQ}:\nThe Questions is : {BodyOfTheQ}");
            foreach (var answer in Answers)
            {
                Console.Write($"{answer.AnswerId} - {answer.AnswerText}");
                Console.Write("                        ");
            }
            Console.WriteLine();
        }
    }
}
