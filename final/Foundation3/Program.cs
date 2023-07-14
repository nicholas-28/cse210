using System;
class Program
{
    static void Main(string[] args)
    {
        var events = new List<Event>
        {
            new Lecture("AI Summit", "A lecture on the future of AI", "2023-09-12", "10:00", new Address("123 Main St", "San Francisco", "CA", "USA"), "Dr. Jane Doe", 500),
            new Reception("Tech Conference Reception", "Join us for a reception after the Tech Conference", "2023-09-13", "19:00", new Address("456 Union Square", "San Francisco", "CA", "USA"), "rsvp@techconf.com"),
            new OutdoorGathering("Summer Tech Picnic", "Outdoor picnic for tech enthusiasts", "2023-09-14", "12:00", new Address("789 Golden Gate Park", "San Francisco", "CA", "USA"), "Sunny")
        };

        foreach (var eventItem in events)
        {
            Console.WriteLine("----- Standard Details -----");
            Console.WriteLine(eventItem.GetStandardDetails());
            Console.WriteLine("----- Full Details -----");
            Console.WriteLine(eventItem.GetFullDetails());
            Console.WriteLine("----- Short Description -----");
            Console.WriteLine(eventItem.GetShortDescription());
            Console.WriteLine("\n");
        }
    }
}