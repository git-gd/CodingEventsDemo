using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.Models
{
    public class EventTag
    {
        public int EventId { get; set; }
        public Event Event { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }

        public EventTag()
        {
        }

        public override string ToString()
        {
            return Tag.Name; // the only place I use ToString is in EventDetailViewModel..
        }
    }
}
