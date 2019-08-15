using System;

namespace GetForms
{
    public abstract class Question
    {
        public string Text { get; set; }

        public abstract string GetAnswer();
    }
}
