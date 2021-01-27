using SQLite;

namespace UnityAPI.Models
{
    public class Answers
    {
        [PrimaryKey] [Unique] [AutoIncrement] public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string AnswerText { get; set; }
        public int AnswerTypeId { get; set; }
        public bool IsCorrect { get; set; }
        public bool Description { get; set; }
    }
}