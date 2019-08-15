namespace GetForms
{
    public class SexQuestion : MultipleChoiceQuestion
    {
        public SexQuestion()
        {
            Text = "Kjønn";
            Options = new[] {"Mann", "Kvinne"};
        }
    }
}
