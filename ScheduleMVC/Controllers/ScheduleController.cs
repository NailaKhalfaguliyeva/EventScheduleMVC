using ScheduleMVC.Context;
using ScheduleMVC.Entities;
using System;
using System.Linq;
using System.Web.Mvc;

namespace _08PC_MVCCodeFirst.Controllers
{
    public class ScheduleController : Controller
    {
        MVCContext context = new MVCContext();

        public ActionResult Index()
        {
            ViewBag.Departments = context.Departments.ToList();
            ViewBag.Events = context.Events.ToList();
            return View();
        }

        public JsonResult GetCalendarEvents()
        {
            var values = context.EventSchedules
                .ToList()
                .Select(x => new
                {
                    id = x.EventScheduleId,
                    title = x.Event.Title,
                    start = x.StartDate.ToString("yyyy-MM-dd"),
                    end = x.EndDate.ToString("yyyy-MM-dd"),
                    allDay = true,
                    color = x.Event.Department.Color
                })
                .ToList();

            return Json(values, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SaveCalendarEvent(int eventId, string startDate, string endDate)
        {
            EventSchedule value = new EventSchedule();

            value.EventId = eventId;
            value.StartDate = DateTime.Parse(startDate);
            value.EndDate = DateTime.Parse(endDate);
            value.AllDay = true;

            context.EventSchedules.Add(value);
            context.SaveChanges();

            return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpdateCalendarEvent(int scheduleId, string startDate, string endDate)
        {
            var value = context.EventSchedules.Find(scheduleId);

            if (value != null)
            {
                value.StartDate = DateTime.Parse(startDate);
                value.EndDate = DateTime.Parse(endDate);
                value.AllDay = true;

                context.SaveChanges();
            }

            return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteCalendarEvent(int scheduleId)
        {
            var value = context.EventSchedules.Find(scheduleId);

            if (value != null)
            {
                context.EventSchedules.Remove(value);
                context.SaveChanges();
            }

            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}