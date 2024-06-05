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
        Console.WriteLine($"Title: {GetTitle()}");  
        Console.WriteLine($"Description: {GetDescription()}");  
        Console.WriteLine($"Date: {GetDate()}");  
        Console.WriteLine($"Time: {GetTime()}");  
        Console.WriteLine($"Address: {GetAddress()}");
        Console.WriteLine($"RSVP email: {_rsvpEmail}");
    }

    public override void GetShortDescription()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Date: {GetDate()}");
    }
}
