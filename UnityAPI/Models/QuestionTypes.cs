using SQLite;

namespace UnityAPI.Models
{
    public class QuestionTypes
    {
        [PrimaryKey] [Unique] [AutoIncrement] public int QuestionTypeId { get; set; }
        public int QuestionId { get; set; }
        public int TypeId { get; set; }
    }
}