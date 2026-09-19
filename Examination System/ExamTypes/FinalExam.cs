using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_System.ExamTypes
{
    internal class FinalExam : Exam
    {

        public FinalExam(int time, int num) : base(time, num) { }

        public override void ShowExam()
        {
            Console.WriteLine("=== Final Exam ===");
            Console.WriteLine($"Time: {Time} Minutes | Questions: {NumberOfQuestions}");
            Console.WriteLine("-------------------------");

            foreach (var q in Questions)
            {
                q.ShowQuestion(); 
                Console.WriteLine("-------------------------");
            }

            
        }
    }
}
