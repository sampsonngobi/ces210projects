using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        // Create Addresses 
        Console.Clear();
        Address address1 = new Address("No 4 Pop Street", "London", "Brasilia", "Brazil");
        Address address2 = new Address("No 6 Eke Street", "Lagos", "Lagos", "Nigeria");
        Address address3 = new Address("No 2 Pop Street", "London", "Brasilia", "Brazil");

              
        // Create Events 
        Reception reception = new Reception("sampson@gmail.com", "Sunset Music Festival", "Join us for an unforgettable evening at the Sunset Music Festival! Enjoy live performances from top artists as the sun sets, creating a magical atmosphere.", "June 12, 2024", "12:00 PM", address1);
        Lecture lecture = new Lecture("Ken Osas", 1000, "The Future of Renewable Energy", "Join us for an enlightening lecture on the advancements and future prospects of renewable energy.", "Jan 6, 2024", "9:00 PM", address2);
        OutDoorGathering outDoorGathering = new OutDoorGathering("Cloudy", "Park Day Out", "A good time out at the park with friends and loved ones", "September 30, 2024", "1:00 PM", address3);

        Event[] events = new Event[] { lecture, reception, outDoorGathering };

        foreach (var ev in events)
        {
            ev.GetFullDetails();
            Console.WriteLine();
            ev.GetStandardDetails();
            Console.WriteLine();
            ev.GetShortDescription();
            Console.WriteLine("--------------------------------------------");
        }
    }
}
