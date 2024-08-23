namespace AssignmentsAPIChallenge.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Data { get; set; }
        public EnumAssignmentStatus Status { get; set; }
    }
}