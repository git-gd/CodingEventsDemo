using CodingEventsDemo.Data;
using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.Controllers
{
    public class EventCategoryController : Controller
    {
        private EventDbContext context;

        public EventCategoryController(EventDbContext dbContext)
        {
            context = dbContext;
        }

        //Index() needs to do the following:

        //Responds to GET requests at EventCategory/Index and returns a view called Index.cshtml.
        //Pass the DbContext category values as a list into the view template as a model.
        [HttpGet]
        public IActionResult Index()
        {
            List<EventCategory> eventCategory = context.EventCategories.ToList();

            return View(eventCategory);
        }
    }
}
