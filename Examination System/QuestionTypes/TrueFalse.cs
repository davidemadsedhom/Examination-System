using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Examination_System.QuestionTypes
{

    public class TrueFalse : Question
    {

       
         public TrueFalse(string header, string body, int mark) : base(header, body, mark)
            {
               
                AnswerList = new Answer[2];
                AnswerList[0] = new Answer(1, "True");
                AnswerList[1] = new Answer(2, "False");
            }

            
            public override void ShowQuestion()
            {
                Console.WriteLine($"{Header} (Mark: {Mark})");
                Console.WriteLine(Body);
                foreach (var ans in AnswerList)
                {
                Console.WriteLine(ans.ToString());
            }
        }
    }
}
