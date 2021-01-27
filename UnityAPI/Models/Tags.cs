using SQLite;

namespace UnityAPI.Models
{
    public class Tags
    {
        [PrimaryKey] [Unique] [AutoIncrement] public int TagId { get; set; }
        public string TagName { get; set; }
        public string TagDescription { get; set; }
    }
}