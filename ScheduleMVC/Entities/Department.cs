using System.Collections.Generic;

namespace ScheduleMVC.Entities
{
	public class Department
	{
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Color { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}