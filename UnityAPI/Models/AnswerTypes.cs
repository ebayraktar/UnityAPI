using SQLite;

namespace UnityAPI.Models
{
    public class AnswerTypes
    {
        [PrimaryKey] [Unique] [AutoIncrement] public int AnswerTypeId { get; set; }
        public int AnswerId { get; set; }
        public int TypeId { get; set; }
    }
}