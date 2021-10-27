using System; 

namespace Backend.Models
{
    public class Animal
    {
        public Guid AnimalId { get; set; }
        public string Name { get; set; }
        public AnimalSizes Size { get; set; }
    }
}
