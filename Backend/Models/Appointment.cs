using System;
using System.Collections.Generic; 

namespace Backend.Models
{
    public class Appointment
    {
        public Guid AppointmentId { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual Pet Pet { get; set; }
        public virtual List<Note> Notes { get; set; }
    }
}
