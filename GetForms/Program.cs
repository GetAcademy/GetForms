using System;

namespace GetForms
{
    class Program
    {
        static void Main(string[] args)
        {
            var questionSet = new QuestionSet();
            questionSet.Run();

            Console.WriteLine();
            Console.WriteLine();

            questionSet.ShowSummary();
        }
    }
}
