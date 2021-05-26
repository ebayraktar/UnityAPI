using SQLite;

namespace UnityAPI.Models
{
    public class Answers
    {
        [PrimaryKey] [Unique] [AutoIncrement] public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
        public byte[] ImageUrl { get; set; }
        public bool Description { get; set; }
    }
}