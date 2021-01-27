using SQLite;

namespace UnityAPI.Models
{
    public class Types
    {
        [PrimaryKey] [Unique] [AutoIncrement] public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string TypeDescription { get; set; }
    }
}