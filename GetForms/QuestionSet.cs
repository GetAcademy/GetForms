using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetForms
{
    class QuestionSet
    {
        private Question[] _questions;
        private string[] _answers;

        public QuestionSet()
        {
            _questions = new Question[]
            {
                new MultipleChoiceWithTextOptionQuestion
                {
                    Text = "Hvordan har dagen din vært?",
                    Options = new []{"Bra", "Greit", "Dårlig"}
                }, 
                //new TextQuestion{Text="Hva heter du?"},
                //new TextQuestion{Text="Hvor bor du?"},
                //new SexQuestion(),
            };
            _answers = new string[_questions.Length];
        }

        public void Run()
        {
            for (var index = 0; index < _questions.Length; index++)
            {
                var question = _questions[index];
                Console.Write(question.Text + " ");
                var answer = question.GetAnswer();
                _answers[index] = answer;
            }
        }

        public void ShowSummary()
        {
            for (var index = 0; index < _questions.Length; index++)
            {
                var question = _questions[index];
                var answer = _answers[index];
                Console.WriteLine($"{index + 1}: {question.Text} => {answer}");
            }
        }
    }
}
