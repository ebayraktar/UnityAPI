namespace UnityAPI.Models
{
    public class Students : Users
    {
        public int GradeId { get; set; }
        public string BirthDate { get; set; }
        public int GuardianId { get; set; }
        public int TeacherId { get; set; }
    }
}