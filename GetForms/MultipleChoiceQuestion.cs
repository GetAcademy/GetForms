using System;

namespace GetForms
{
    public class MultipleChoiceQuestion : Question
    {
        public string[] Options { get; set; }
        public override string GetAnswer()
        {
            Console.WriteLine("Alternativer:");
            for (var index = 0; index < Options.Length; index++)
            {
                ShowOption(index, Options[index]);
            }
            ShowExtraOptions();
            Console.Write("Tast ønsket tall: ");
            var selectedIndex = Convert.ToInt32(Console.ReadKey().KeyChar.ToString()) - 1;
            Console.WriteLine();
            return GetAlternativeAnswer(selectedIndex) ?? Options[selectedIndex];
        }

        protected static void ShowOption(int index, string option)
        {
            Console.WriteLine($"  {index + 1}: {option}");
        }

        protected virtual string GetAlternativeAnswer(int selectedIndex)
        {
            return null;
        }

        protected virtual void ShowExtraOptions()
        {
        }
    }
}
