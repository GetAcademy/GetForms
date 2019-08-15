using System;

namespace GetForms
{
    public class MultipleChoiceWithTextOptionQuestion : MultipleChoiceQuestion
    {
        protected override string GetAlternativeAnswer(int selectedIndex)
        {
            if (selectedIndex < Options.Length) return null;
            Console.Write("Skriv inn ditt svar: ");
            return Console.ReadLine();
        }

        protected override void ShowExtraOptions()
        {
            ShowOption(Options.Length, "Skriv inn egen tekst som svar");
        }
    }
}
