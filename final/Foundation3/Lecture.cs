using System;

public class Lecture : Event
{
    private string _speaker; 
    private int _capacity;
    private string _eventType = "LECTURE";    
   

    public Lecture(string speaker, int capacity, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _speaker = speaker ;
        _capacity = capacity;
    }

    public override void GetFullDetails()
    {
        Console.WriteLine("FULL DETAI>S:");
        Console.WriteLine($"Title: {_title}");  
        Console.WriteLine($"Description: {_description}");  
        Console.WriteLine($"Date: {_date}");  
        Console.WriteLine($"Time: {_time}");  
        Console.WriteLine($"Address: {_address.GetAddress()}");
        Console.WriteLine($"Speaker:{_speaker} Capacity: {_capacity}");

    }

      public override void GetShortDescription()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
   
}