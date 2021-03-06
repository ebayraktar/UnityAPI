using SQLite;

namespace UnityAPI.Models
{
    public class Books
    {
        [PrimaryKey]
        [Unique]
        public string BookId { get; set; }
        public string Name { get; set; }
        public string PageCount { get; set; }
        public string Point { get; set; }
        public string AuthorId { get; set; }
        public string TypeId { get; set; }
    }
}