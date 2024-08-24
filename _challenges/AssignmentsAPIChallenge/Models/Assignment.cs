using System.Text.Json.Serialization;

namespace AssignmentsAPIChallenge.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EnumAssignmentStatus Status { get; set; }
    }
}