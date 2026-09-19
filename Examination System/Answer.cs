using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_System
{
    internal class Answer
    {
        int answerId;
        string answerText;

        public override string ToString()
        {
            return $"Answer ID: {answerId}, \nAnswer Text: {answerText}";
        }
    }
}
