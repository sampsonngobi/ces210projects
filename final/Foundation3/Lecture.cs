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
        Console.WriteLine("FULL DETAILS:");
        Console.WriteLine($"Title: {GetTitle()}");  
        Console.WriteLine($"Description: {GetDescription()}");  
        Console.WriteLine($"Date: {GetDate()}");  
        Console.WriteLine($"Time: {GetTime()}");  
        Console.WriteLine($"Address: {GetAddress()}");
        Console.WriteLine($"Speaker:{_speaker} Capacity: {_capacity}");

    }

      public override void GetShortDescription()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Date: {GetDate()}");
    }
   
}