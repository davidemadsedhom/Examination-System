using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Examination_System.QuestionTypes
{
    public class MCQ : Question
    {
        public MCQ(string header, string body, int mark) : base(header, body, mark)
        {
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header} (Mark: {Mark})");
            Console.WriteLine(Body);
            if (AnswerList != null)
            {
                foreach (var ans in AnswerList)
                {
                    Console.WriteLine(ans.ToString());
                }
            }
        }
    }
}
