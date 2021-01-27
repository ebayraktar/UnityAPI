using SQLite;

namespace UnityAPI.Models
{
    public class Questions
    {
        [PrimaryKey] [Unique] [AutoIncrement] public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int Point { get; set; }
        public bool IsDeleted { get; set; }
    }
}