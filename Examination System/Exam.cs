    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace Examination_System
    {
      
         public abstract class Exam
        {
            public int Time { get; set; }            
            public int NumberOfQuestions { get; set; }

           
            public List<Question> Questions { get; set; }

            public Exam(int time, int numberOfQuestions)
            {
                Time = time;
                NumberOfQuestions = numberOfQuestions;
                Questions = new List<Question>();
            }

            
            public abstract void ShowExam();
        }
    }
   
