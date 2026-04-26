using ScheduleMVC.Context;
using ScheduleMVC.Entities;
using System.Linq;
using System.Web.Mvc;

namespace _08PC_MVCCodeFirst.Controllers
{
    public class EventController : Controller
    {
        MVCContext context = new MVCContext();

        public ActionResult EventList()
        {
            var values = context.Events.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateEvent()
        {
            ViewBag.Departments = context.Departments.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult CreateEvent(Event events)
        {
            context.Events.Add(events);
            context.SaveChanges();
            return RedirectToAction("EventList");
        }

        public ActionResult DeleteEvent(int id)
        {
            var value = context.Events.Find(id);
            context.Events.Remove(value);
            context.SaveChanges();
            return RedirectToAction("EventList");
        }

        [HttpGet]
        public ActionResult UpdateEvent(int id)
        {
            ViewBag.Departments = context.Departments.ToList();
            var value = context.Events.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateEvent(Event events)
        {
            var value = context.Events.Find(events.EventId);
            value.Title = events.Title;
            value.DepartmentId = events.DepartmentId;
            context.SaveChanges();
            return RedirectToAction("EventList");
        }
    }
}