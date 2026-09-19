using Examination_System.ExamTypes;
using Examination_System.QuestionTypes;

namespace Examination_System
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            Subject math = new Subject(1, "Math");

            
            math.SubjectExam = new FinalExam(60, 1); 

            
            Question q1 = new TrueFalse("Q1", "Is OOP Easy?", 10);
            q1.RightAnswer = q1.AnswerList[0]; 
            math.SubjectExam.Questions.Add(q1);

            
            math.SubjectExam.ShowExam();
        }
    }
}
