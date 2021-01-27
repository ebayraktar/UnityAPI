using SQLite;

namespace UnityAPI.Models
{
    public class QuestionCategories
    {
        [PrimaryKey] [Unique] [AutoIncrement] public int QuestionCategoryId { get; set; }
        public int QuestionId { get; set; }
        public int CategoryId { get; set; }
    }
}