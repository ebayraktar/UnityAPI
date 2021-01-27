using SQLite;

namespace UnityAPI.Models
{
    public class Grades
    {
        [PrimaryKey] [Unique] [AutoIncrement] public int GradeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; }
    }
}