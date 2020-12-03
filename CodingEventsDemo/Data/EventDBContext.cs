using CodingEventsDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.Data
{
    public class EventDBContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public EventDBContext(DbContextOptions<EventDBContext> options) : base(options)
        {
        }
    }
}
