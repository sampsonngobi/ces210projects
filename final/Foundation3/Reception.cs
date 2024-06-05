using System;

public class Reception : Event
{
    private string _rsvpEmail; 
    private string _eventType = "RECEPTION";    

    public Reception(string rsvpEmail, string title, string description, string date, string time, Address address) 
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override void GetFullDetails()
    {
        Console.WriteLine("FULL DETAILS:");
        Console.WriteLine($"Title: {_title}");  
        Console.WriteLine($"Description: {_description}");  
        Console.WriteLine($"Date: {_date}");  
        Console.WriteLine($"Time: {_time}");  
        Console.WriteLine($"Address: {_address.GetAddress()}");
        Console.WriteLine($"RSVP email: {_rsvpEmail}");
    }

    public override void GetShortDescription()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
}
