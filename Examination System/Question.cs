using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_System
{
    public abstract class Question : ICloneable, IComparable
    {

        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }



        public object Clone()
        {
            return this.MemberwiseClone();
        }


        public abstract void ShowQuestion();

        public int CompareTo(object obj)
        {
            Question q = (Question)obj;
            return this.Mark.CompareTo(q.Mark);
        }
    }
}
