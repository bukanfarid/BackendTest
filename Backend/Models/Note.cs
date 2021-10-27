using System; 

namespace Backend.Models
{
    public class Note
    {
        public Guid NoteId { get; set; }
        public string Summary { get; set; }
        public string Detail { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
