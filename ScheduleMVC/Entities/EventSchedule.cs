using System;

namespace ScheduleMVC.Entities
{
	public class EventSchedule
	{
        public int EventScheduleId { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool AllDay { get; set; }
    }
}