using SQLite;

namespace UnityAPI.Models
{
    public class AgeGroups
    {
        [PrimaryKey] [Unique] [AutoIncrement] public int AgeGroupId { get; set; }
        public string AgeGroupName { get; set; }
        public string AgeGroupDescription { get; set; }
    }
}