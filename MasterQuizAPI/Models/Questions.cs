namespace MasterQuizAPI.Models
{
    public class Choice
    {
        public int ChoiceId { get; set; }
        public int QuestId { get; set; }
        public string? ChoiceText { get; set; }
        public bool? IsTrue { get; set; }
    }

    public class Questions
    {
        public int QuestId { get; set; }    
        public int QuestNumber { get; set; }
        public string? QuestText { get; set; }
    }
}
