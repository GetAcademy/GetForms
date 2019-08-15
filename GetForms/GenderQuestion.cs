namespace GetForms
{
    public class GenderQuestion : MultipleChoiceQuestion
    {
        public GenderQuestion()
        {
            Text = "Kjønn";
            Options = new[] {"Mann", "Kvinne"};
        }
    }
}
