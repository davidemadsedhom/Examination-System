using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_System
{
    public class Subject
    {

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

       
        public Exam SubjectExam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        
        public void CreateExam()
        {
            
        }
    }
}
