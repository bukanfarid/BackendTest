using System;

namespace Backend.Filter
{
    public class AppointmentFilter : PaginationFilter
    {
        public string date { get; set; }
        public string petName { get; set; }

        public AppointmentFilter()
        {
            this.date = null;
            this.petName = null;
        }
        public AppointmentFilter(int pageNumber, int pageSize, string date, string petName)
        {
            this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
            this.PageSize = pageSize > 100 ? 100 : pageSize;
            this.date = date;
            this.petName = petName;
        }
    }
}
