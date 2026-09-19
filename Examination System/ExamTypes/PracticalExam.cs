using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_System.ExamTypes
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int num) : base(time, num) { }

        public override void ShowExam()
        {
            Console.WriteLine("=== Practical Exam ===");
            Console.WriteLine($"Time: {Time} Minutes | Questions: {NumberOfQuestions}");
            Console.WriteLine("-------------------------");

            foreach (var q in Questions)
            {
                q.ShowQuestion();

                Console.WriteLine($"-> Right Answer: {q.RightAnswer}");
                Console.WriteLine("-------------------------");
            }
        }
    }
}
