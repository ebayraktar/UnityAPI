using SQLite;

namespace UnityAPI.Models
{
    public class QuestionTags
    {
        [PrimaryKey] [Unique] [AutoIncrement] public int QuestionTagId { get; set; }
        public int QuestionId { get; set; }
        public int TagId { get; set; }
    }
}