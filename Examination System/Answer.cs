using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_System
{
    internal class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(int id, string text)
        {
            AnswerId = id;
            AnswerText = text;
        }

        public override string ToString()
        {
            return $"Answer ID: {AnswerId}, \nAnswer Text: {AnswerText}";
        }
    }
}
