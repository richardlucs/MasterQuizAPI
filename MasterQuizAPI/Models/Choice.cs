namespace MasterQuizAPI.Models
{
    public class Choice
    {
        public int ChoiceId { get; set; }
        public int QuestionId { get; set; }
        public string? ChoiceText { get; set; }
        public bool IsTrue { get; set; }
    }
}
