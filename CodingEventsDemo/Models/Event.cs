using System;
using Microsoft.AspNetCore.Mvc;

namespace CodingEventsDemo.Models
{
    public class Event
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public int Attendees { get; set; }

        public string ContactEmail { get; set; }

        public int Id { get; }
        static private int nextId = 1;

        public Event(string name, string description, string location, int attendees, string contactEmail)
        {
            Name = name;
            Description = description;
            Location = location;
            Attendees = attendees;
            ContactEmail = contactEmail;
            Id = nextId;
            nextId++;
        }

        public Event()
        {
            Id = nextId;
            nextId++;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Event @event &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
