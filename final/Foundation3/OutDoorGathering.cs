using System;

public class OutDoorGathering : Event
{
    private string _weatherForecast; 
    private string _eventType = "OUT DOOR GATHERING";    

    public OutDoorGathering(string weatherForecast, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
       
    }

   public override void GetFullDetails()
    {
         Console.WriteLine("FULL DETAILS:");
        Console.WriteLine($"Title: {GetTitle()}");  
        Console.WriteLine($"Description: {GetDescription()}");  
        Console.WriteLine($"Date: {GetDate()}");  
        Console.WriteLine($"Time: {GetTime()}");  
        Console.WriteLine($"Address: {GetAddress()}");
        Console.WriteLine($"The weather is {_weatherForecast}");

    }

      public override void GetShortDescription()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Date: {GetDate()}");
    }
}