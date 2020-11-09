using System;
namespace CodingEventsDemo.Models
{
    public class Event
    {
        private static int classId = 1;
        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Event()
        {
            Id = classId;
            classId += 1;
        }

        public Event(string name, string description) :this()
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
