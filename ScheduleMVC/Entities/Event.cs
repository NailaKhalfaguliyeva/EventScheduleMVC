using System.Collections.Generic;

namespace ScheduleMVC.Entities
{
	public class Event
	{
        public int EventId { get; set; }
        public string Title { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual  ICollection<EventSchedule> EventSchedules { get; set; }
    }
}