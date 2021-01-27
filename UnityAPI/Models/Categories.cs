using SQLite;

namespace UnityAPI.Models
{
    public class Categories
    {
        [PrimaryKey] [Unique] [AutoIncrement] public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}