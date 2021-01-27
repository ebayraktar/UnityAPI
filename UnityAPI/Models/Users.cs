using SQLite;

namespace UnityAPI.Models
{
    public class Users
    {
        [PrimaryKey] [Unique] [AutoIncrement] public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CreateDate { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; }
    }
}