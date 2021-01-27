using SQLite;

namespace UnityAPI.Models
{
    public class QuestionAgeGroups
    {
        [PrimaryKey] [Unique] [AutoIncrement] public int QuestionAgeGroupId { get; set; }
        public int QuestionId { get; set; }
        public int AgeGroupId { get; set; }
    }
}